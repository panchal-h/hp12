//-----------------------------------------------------------------------
// <copyright file="DBClient.cs" company="Caspian Pacific Tech">
//     Copyright (c) Caspian Pacific Tech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace SmartLibrary.DataContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    /// <summary>
    /// Define the possible execution type for Procedure
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    public enum ExecuteType
    {
        /// <summary>
        /// Execute as Scalar
        /// </summary>
        ExecuteScalar,

        /// <summary>
        /// Execute as Dataset
        /// </summary>
        ExecuteDataSet,

        /// <summary>
        /// Execute as non query
        /// </summary>
        ExecuteNonQuery,

        /// <summary>
        /// Execute as Reader
        /// </summary>
        ExecuteReader
    }

    /// <summary>
    /// This class is to define common methods for do the DBCall using Stored Procedure with SQL Command
    /// </summary>
    /// <CreatedBy>Hardik Panchal</CreatedBy>
    /// <CreatedDate>14-Aug-2018</CreatedDate>
    /// <ModifiedBy></ModifiedBy>
    /// <ModifiedDate></ModifiedDate>
    /// <ReviewBy></ReviewBy>
    /// <ReviewDate></ReviewDate>
    internal sealed class DBClient
    {
        #region Property/Enum

        /// <summary>
        /// Initializes a new instance of the <see cref="DBClient"/> class.
        /// Prevents a default instance of the DBClient class from being created.
        /// </summary>
        private DBClient()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Execute the Stored Procedure with given Parameters
        /// </summary>
        /// <param name="procedureName">procedure name</param>
        /// <param name="executeType">execute type</param>
        /// <param name="parameters">procedure parameter</param>
        /// <param name="databaseConnection">Database Connection String</param>
        /// <returns>return execute procedure </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "This will only return predefined Procedure Name, not user inputs")]
        public static object ExecuteProcedure(string procedureName, ExecuteType executeType, System.Collections.ObjectModel.Collection<DBParameters> parameters, string databaseConnection)
        {
            /* Create Database object
            Database db = DatabaseFactory.CreateDatabase();*/
            object returnValue;
            //// Create a suitable command type and add the required parameter
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(databaseConnection))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 60;
                /*Add different Parameter from Model object Property*/
                AddParameters(ref sqlCommand, parameters);

                /*Execute Procedure from supplied Execution type*/

                if (executeType == ExecuteType.ExecuteScalar)
                {
                    returnValue = sqlCommand.ExecuteScalar();
                }
                else if (executeType == ExecuteType.ExecuteDataSet)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dataSet);
                    returnValue = dataSet;
                }
                else if (executeType == ExecuteType.ExecuteNonQuery)
                {
                    returnValue = sqlCommand.ExecuteNonQuery();
                }
                else if (executeType == ExecuteType.ExecuteReader)
                {
                    returnValue = sqlCommand.ExecuteReader();
                }
                else
                {
                    returnValue = "No Proper execute type provide";
                }
            }

            return returnValue;
        }

        /// <summary>
        /// Execute the Stored Procedure with given Parameters
        /// </summary>
        /// <typeparam name="T">Entity Type</typeparam>
        /// <param name="procedureName">procedure name</param>
        /// <param name="parameters">procedure parameter</param>
        /// <param name="databaseConnection">Database Connection String</param>
        /// <returns>return execute procedure </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "This will only return predefined Procedure Name, not user inputs")]
        public static IList<T> ExecuteProcedure<T>(string procedureName, System.Collections.ObjectModel.Collection<DBParameters> parameters, string databaseConnection)
        {
            /* Create Database object
            Database db = DatabaseFactory.CreateDatabase();*/
            List<T> returnValue = new List<T>();

            // Create a suitable command type and add the required parameter
            using (SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(databaseConnection))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(procedureName, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandTimeout = 0;
                /*Add different Parameter from Model object Property*/
                AddParameters(ref sqlCommand, parameters);

                /*Execute Procedure from supplied Execution type*/
                returnValue = DataReaderToList<T>(sqlCommand.ExecuteReader(CommandBehavior.CloseConnection));
            }

            return returnValue;
        }

        /// <summary>
        /// Add Parameter from Model Object Property
        /// </summary>
        /// <param name="sqlCommand">Database object</param>
        /// <param name="parameters">Command Object</param>
        private static void AddParameters(ref SqlCommand sqlCommand, System.Collections.ObjectModel.Collection<DBParameters> parameters)
        {
            foreach (DBParameters parameter in parameters)
            {
                if (parameter.DBType == DbType.Time)
                {
                    SqlParameter sqlParameter = new SqlParameter()
                    {
                        SqlDbType = SqlDbType.Time,
                        Direction = ParameterDirection.Input,
                        ParameterName = parameter.Name,
                        Value = parameter.Value
                    };
                    sqlCommand.Parameters.Add(sqlParameter);
                }
                else
                {
                    SqlParameter sqlParameter = new SqlParameter()
                    {
                        DbType = parameter.DBType,
                        Direction = ParameterDirection.Input,
                        ParameterName = parameter.Name,
                        Value = parameter.Value
                    };
                    sqlCommand.Parameters.Add(sqlParameter);
                }
            }
        }

        /// <summary>
        /// Convert Data Reader to List
        /// </summary>
        /// <typeparam name="T">Entity Object</typeparam>
        /// <param name="dr">data reader object</param>
        /// <returns>return list of objects</returns>
        private static List<T> DataReaderToList<T>(IDataReader dr)
        {
            List<T> list = new List<T>();

            T obj = default(T);

            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    PropertyInfo info = obj.GetType().GetProperties().FirstOrDefault(o => o.Name.ToLower() == dr.GetName(i).ToLower());
                    if (info != null)
                    {
                        /*Set the Value to Model*/
                        info.SetValue(obj, dr.GetValue(i) != System.DBNull.Value ? dr.GetValue(i) : null, null);
                    }
                }

                list.Add(obj);
            }

            dr.Close();
            return list;
        }

        /// <summary>
        /// Set Pagination Properties
        /// </summary>
        /// <param name="totalRecords">Total Records</param>
        /// <param name="pages">Pagination Objects</param>
        private static void SetPaginationInformation(int totalRecords, ref Pagination pages)
        {
            pages.TotalRecords = totalRecords;
            pages.TotalPages = (pages.TotalRecords / pages.PageSize) + ((pages.TotalRecords % pages.PageSize > 0) ? 1 : 0);
            pages.HasPreviousPage = pages.PageNo > pages.PagerSize;
            int currentPagerNo = pages.PageNo / (pages.PagerSize + (pages.PageNo % pages.PagerSize > 0 ? 1 : 0));
            int currentPagerRecords = currentPagerNo * pages.PagerSize;
            pages.HasNextPage = pages.TotalPages > pages.PagerSize ? ((pages.TotalPages % pages.PagerSize) == 0 ? (currentPagerRecords < pages.TotalPages - (pages.TotalPages % pages.PagerSize)) : (currentPagerRecords <= pages.TotalPages - (pages.TotalPages % pages.PagerSize))) : false;
        }
        #endregion
    }
}

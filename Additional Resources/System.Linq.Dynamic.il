
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.18020
//  Copyright (c) Microsoft Corporation.  All rights reserved.


// ----- DOS Header:
// Magic:                      0x5a4d
// Bytes on last page:         0x0090
// Pages in file:              0x0003
// Relocations:                0x0000
// Size of header (paragraphs):0x0004
// Min extra paragraphs:       0x0000
// Max extra paragraphs:       0xffff
// Initial (relative) SS:      0x0000
// Initial SP:                 0x00b8
// Checksum:                   0x0000
// Initial IP:                 0x0000
// Initial (relative) CS:      0x0000
// File addr. of reloc table:  0x0040
// Overlay number:             0x0000
// OEM identifier:             0x0000
// OEM info:                   0x0000
// File addr. of COFF header:  0x0080
// ----- COFF/PE Headers:
// Signature:                  0x00004550
// ----- COFF Header:
// Machine:                    0x014c
// Number of sections:         0x0003
// Time-date stamp:            0x4ee64cd8
// Ptr to symbol table:        0x00000000
// Number of symbols:          0x00000000
// Size of optional header:    0x00e0
// Characteristics:            0x2102
// ----- PE Optional Header (32 bit):
// Magic:                          0x010b
// Major linker version:           0x08
// Minor linker version:           0x00
// Size of code:                   0x0000ac00
// Size of init.data:              0x00000600
// Size of uninit.data:            0x00000000
// Addr. of entry point:           0x0000cb8e
// Base of code:                   0x00002000
// Base of data:                   0x0000e000
// Image base:                     0x00400000
// Section alignment:              0x00002000
// File alignment:                 0x00000200
// Major OS version:               0x0004
// Minor OS version:               0x0000
// Major image version:            0x0000
// Minor image version:            0x0000
// Major subsystem version:        0x0004
// Minor subsystem version:        0x0000
// Size of image:                  0x00012000
// Size of headers:                0x00000200
// Checksum:                       0x00000000
// Subsystem:                      0x0003
// DLL characteristics:            0x8540
// Size of stack reserve:          0x00100000
// Size of stack commit:           0x00001000
// Size of heap reserve:           0x00100000
// Size of heap commit:            0x00001000
// Loader flags:                   0x00000000
// Directories:                    0x00000010
// 0x00000000 [0x00000000] address [size] of Export Directory:          
// 0x0000cb3c [0x0000004f] address [size] of Import Directory:          
// 0x0000e000 [0x000003e8] address [size] of Resource Directory:        
// 0x00000000 [0x00000000] address [size] of Exception Directory:       
// 0x00000000 [0x00000000] address [size] of Security Directory:        
// 0x00010000 [0x0000000c] address [size] of Base Relocation Table:     
// 0x0000caa8 [0x0000001c] address [size] of Debug Directory:           
// 0x00000000 [0x00000000] address [size] of Architecture Specific:     
// 0x00000000 [0x00000000] address [size] of Global Pointer:            
// 0x00000000 [0x00000000] address [size] of TLS Directory:             
// 0x00000000 [0x00000000] address [size] of Load Config Directory:     
// 0x00000000 [0x00000000] address [size] of Bound Import Directory:    
// 0x00002000 [0x00000008] address [size] of Import Address Table:      
// 0x00000000 [0x00000000] address [size] of Delay Load IAT:            
// 0x00002008 [0x00000048] address [size] of CLR Header:                


// Image sections:
//              .text
//              0x0000ab94 Virtual Size
//              0x00002000 Virtual Address
//              0x0000ac00 Size of Raw Data
//              0x00000200 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x60000020 Characteristics
//                         CNT_CODE
//                         MEM_EXECUTE
//                         MEM_READ

//              .rsrc
//              0x000003e8 Virtual Size
//              0x0000e000 Virtual Address
//              0x00000400 Size of Raw Data
//              0x0000ae00 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x40000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_READ

//              .reloc
//              0x0000000c Virtual Size
//              0x00010000 Virtual Address
//              0x00000200 Size of Raw Data
//              0x0000b200 Pointer to Raw Data
//              0x00000000 Pointer to Relocations
//              0x00000000 Pointer to Linenumbers
//                  0x0000 Number of Relocations
//                  0x0000 Number of Linenumbers
//              0x42000040 Characteristics
//                         CNT_INITIALIZED_DATA
//                         MEM_DISCARDABLE
//                         MEM_READ

// Base Relocation Table
//              0x0000c000 Page RVA
//              0x0000000c Block Size
//              0x00000002 Number of Entries
//              Entry 1: Type 0x3 Offset 0x00000b90
//              Entry 2: Type 0x0 Offset 0x00000000

// Import Address Table
//     DLL : mscoree.dll
//              0x00002000 Import Address Table
//              0x0000cb7e Import Name Table
//              0          Time Date Stamp
//              0          Index of First Forwarder Reference
//
//              0x0000  _CorDllMain

// Delay Load Import Address Table
// No data.

// Entry point code:
//FF 25 00 20 40 00 


// ----- CLR Header:
// Header size:                        0x00000048
// Major runtime version:              0x0002
// Minor runtime version:              0x0005
// 0x00005d08 [0x00006da0] address [size] of Metadata Directory:        
// Flags:                              0x00000001
// Entry point token:                  0x00000000
// 0x00000000 [0x00000000] address [size] of Resources Directory:       
// 0x00000000 [0x00000000] address [size] of Strong Name Signature:     
// 0x00000000 [0x00000000] address [size] of CodeManager Table:         
// 0x00000000 [0x00000000] address [size] of VTableFixups Directory:    
// 0x00000000 [0x00000000] address [size] of Export Address Table:      
// 0x00000000 [0x00000000] address [size] of Precompile Header:         

// Metadata Header
//    Storage Signature:
//              0x424a5342 Signature
//                  0x0001 Major Version
//                  0x0001 Minor Version
//              0x00000000 Extra Data Offset
//              0x0000000c Version String Length
//              'v4.0.30319' Version String
//    Storage Header:
//                    0x00 Flags
//                  0x0005 Number of Streams
//    Stream 1:
//              0x0000006c Offset
//              0x00002424 Size
//              '#~' Name
//    Stream 2:
//              0x00002490 Offset
//              0x00002018 Size
//              '#Strings' Name
//    Stream 3:
//              0x000044a8 Offset
//              0x00000ed8 Size
//              '#US' Name
//    Stream 4:
//              0x00005380 Offset
//              0x00000010 Size
//              '#GUID' Name
//    Stream 5:
//              0x00005390 Offset
//              0x00001a10 Size
//              '#Blob' Name

//    Metadata Stream Header:
//              0x00000000 Reserved
//                    0x02 Major
//                    0x00 Minor
//                    0x00 Heaps
//                    0x01 Rid
//      0x00000e090ba21f57 MaskValid
//      0x000016003325fa00 Sorted

// Code Manager Table:
//  default


// Export Address Table Jumps:
// No data.

// File size            : 46080
// PE header size       : 512 (496 used)    ( 1.11%)
// PE additional info   : 1199              ( 2.60%)
// Num.of PE sections   : 3
// CLR header size     : 72                 ( 0.16%)
// CLR meta-data size  : 28064              (60.90%)
// CLR additional info : 0                  ( 0.00%)
// CLR method headers  : 1201               ( 2.61%)
// Managed code         : 14213             (30.84%)
// Data                 : 1536              ( 3.33%)
// Unaccounted          : -717              (-1.56%)

// Num.of PE sections   : 3
//   .text    - 44032
//   .rsrc    - 1024
//   .reloc   - 512

// CLR meta-data size  : 28064
//   Module        -    1 (10 bytes)
//   TypeDef       -   26 (364 bytes)     9 interfaces, 0 explicit layout
//   TypeRef       -  122 (732 bytes)
//   MethodDef     -  207 (2898 bytes)    71 abstract, 0 native, 136 bodies
//   FieldDef      -  125 (750 bytes)     8 constant
//   MemberRef     -  232 (1392 bytes)
//   ParamDef      -  281 (1686 bytes)
//   MethodImpl    -    7 (42 bytes)
//   Constant      -   76 (456 bytes)
//   CustomAttribute-   53 (318 bytes)
//   StandAloneSig -   69 (138 bytes)
//   InterfaceImpl -   12 (48 bytes)
//   PropertyMap   -    3 (12 bytes)
//   Property      -    5 (30 bytes)
//   MethodSemantic-    5 (30 bytes)
//   TypeSpec      -   23 (46 bytes)
//   Assembly      -    1 (22 bytes)
//   AssemblyRef   -    2 (40 bytes)
//   NestedClass   -   15 (60 bytes)
//   GenericParam  -    4 (32 bytes)
//   MethodSpec    -    9 (36 bytes)
//   Strings       -  8214 bytes
//   Blobs         -  6672 bytes
//   UserStrings   -  3800 bytes
//   Guids         -    16 bytes
//   Uncategorized -   220 bytes

// CLR method headers : 1201
//   Num.of method bodies  - 136
//   Num.of fat headers    - 86
//   Num.of tiny headers   - 50
//   Num.of fat sections   - 0
//   Num.of small sections - 7

// Managed code : 14213
//   Ave method size - 104
// Classes defined in this module:
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Class DynamicQueryable               (public) (abstract) (auto) (ansi) (sealed) 
// Class DynamicClass                   (public) (abstract) (auto) (ansi) 
// Class DynamicProperty                (public) (auto) (ansi) 
// Class DynamicExpression              (public) (abstract) (auto) (ansi) (sealed) 
// Class DynamicOrdering                (auto) (ansi) 
// Class Signature                      (auto) (ansi) 
// Class ClassFactory                   (auto) (ansi) 
// Class ParseException                 (public) (auto) (ansi) (sealed) 
// Class ExpressionParser               (auto) (ansi) 
// Class Token                          (sequential) (ansi) (sealed) (nested private) 
// Class TokenId                        (auto) (ansi) (sealed) (nested private) 
// Interface ILogicalSignatures             (abstract) (auto) (ansi) (nested private) 
// Interface IArithmeticSignatures          (abstract) (auto) (ansi) (nested private) 
// Interface IRelationalSignatures          (abstract) (auto) (ansi) (nested private) 
// Interface IEqualitySignatures            (abstract) (auto) (ansi) (nested private) 
// Interface IAddSignatures                 (abstract) (auto) (ansi) (nested private) 
// Interface ISubtractSignatures            (abstract) (auto) (ansi) (nested private) 
// Interface INegationSignatures            (abstract) (auto) (ansi) (nested private) 
// Interface INotSignatures                 (abstract) (auto) (ansi) (nested private) 
// Interface IEnumerableSignatures          (abstract) (auto) (ansi) (nested private) 
// Class MethodData                     (auto) (ansi) (nested private) 
// Class Res                            (abstract) (auto) (ansi) (sealed) 
// Class <SelfAndBaseClasses>d__5       (auto) (ansi) (sealed) (nested private) 
// Class <>c__DisplayClassf             (auto) (ansi) (sealed) (nested private) 
// Class <>c__DisplayClass11            (auto) (ansi) (sealed) (nested private) 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


// Metadata version: v4.0.30319
.assembly extern /*23000001*/ mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern /*23000002*/ System.Core
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly /*20000001*/ System.Linq.Dynamic
{
  .custom /*0C000002:0A000011*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilationRelaxationsAttribute/*0100002F*/::.ctor(int32) /* 0A000011 */ = ( 01 00 08 00 00 00 00 00 ) 
  .custom /*0C000003:0A000006*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyCompanyAttribute/*01000023*/::.ctor(string) /* 0A000006 */ = ( 01 00 09 4D 69 63 72 6F 73 6F 66 74 00 00 )       // ...Microsoft..
  .custom /*0C000004:0A00000F*/ instance void [mscorlib/*23000001*/]System.Runtime.Versioning.TargetFrameworkAttribute/*0100002C*/::.ctor(string) /* 0A00000F */ = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                                                                                     2C 56 65 72 73 69 6F 6E 3D 76 34 2E 30 01 00 54   // ,Version=v4.0..T
                                                                                                                                                                     0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                                                                                     61 79 4E 61 6D 65 10 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                                                                                     65 77 6F 72 6B 20 34 )                            // ework 4
  .custom /*0C000005:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
  .custom /*0C000006:0A000012*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute/*01000030*/::.ctor() /* 0A000012 */ = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                                                                          63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .custom /*0C000007:0A000003*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyTitleAttribute/*01000020*/::.ctor(string) /* 0A000003 */ = ( 01 00 13 53 79 73 74 65 6D 2E 4C 69 6E 71 2E 44   // ...System.Linq.D
                                                                                                                                                           79 6E 61 6D 69 63 00 00 )                         // ynamic..
  .custom /*0C000008:0A000004*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyDescriptionAttribute/*01000021*/::.ctor(string) /* 0A000004 */ = ( 01 00 14 46 6F 72 20 2E 4E 65 74 20 34 20 46 72   // ...For .Net 4 Fr
                                                                                                                                                                 61 6D 65 77 6F 72 6B 00 00 )                      // amework..
  .custom /*0C000009:0A000005*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyConfigurationAttribute/*01000022*/::.ctor(string) /* 0A000005 */ = ( 01 00 00 00 00 ) 

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom /*0C00000A:0A000010*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggableAttribute/*0100002D*/::.ctor(valuetype [mscorlib/*23000001*/]System.Diagnostics.DebuggableAttribute/*0100002D*//DebuggingModes/*0100002E*/) /* 0A000010 */ = ( 01 00 02 00 00 00 00 00 ) 

  .custom /*0C00000B:0A000007*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyProductAttribute/*01000024*/::.ctor(string) /* 0A000007 */ = ( 01 00 13 53 79 73 74 65 6D 2E 4C 69 6E 71 2E 44   // ...System.Linq.D
                                                                                                                                                             79 6E 61 6D 69 63 00 00 )                         // ynamic..
  .custom /*0C00000C:0A000008*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyCopyrightAttribute/*01000025*/::.ctor(string) /* 0A000008 */ = ( 01 00 1C 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                                                                               4D 69 63 72 6F 73 6F 66 74 20 20 32 30 31 31 00   // Microsoft  2011.
                                                                                                                                                               00 ) 
  .custom /*0C00000D:0A000009*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyTrademarkAttribute/*01000026*/::.ctor(string) /* 0A000009 */ = ( 01 00 00 00 00 ) 
  .custom /*0C00000E:0A00000B*/ instance void [mscorlib/*23000001*/]System.Runtime.InteropServices.ComVisibleAttribute/*01000028*/::.ctor(bool) /* 0A00000B */ = ( 01 00 00 00 00 ) 
  .custom /*0C00000F:0A00000C*/ instance void [mscorlib/*23000001*/]System.Runtime.InteropServices.GuidAttribute/*01000029*/::.ctor(string) /* 0A00000C */ = ( 01 00 24 65 61 63 65 61 30 33 66 2D 66 62 61 30   // ..$eacea03f-fba0
                                                                                                                                                               2D 34 33 62 34 2D 61 35 64 32 2D 34 39 30 37 30   // -43b4-a5d2-49070
                                                                                                                                                               31 61 32 35 61 65 37 00 00 )                      // 1a25ae7..
  .custom /*0C000010:0A00000E*/ instance void [mscorlib/*23000001*/]System.Reflection.AssemblyFileVersionAttribute/*0100002B*/::.ctor(string) /* 0A00000E */ = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module System.Linq.Dynamic.dll
// MVID: {3CB6A087-842B-4D42-96C5-C7A1CD39AE79}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x026F0000


// =============== CLASS MEMBERS DECLARATION ===================

.class /*02000002*/ public abstract auto ansi sealed beforefieldinit System.Linq.Dynamic.DynamicQueryable
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .custom /*0C000012:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
  .method /*06000001*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T> 
          Where<T>(class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T> source,
                   string predicate,
                   object[] values) cil managed
  // SIG: 10 01 03 15 12 19 01 1E 00 15 12 19 01 1E 00 0E 1D 1C
  {
    .custom /*0C000001:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [3]/*08000003*/ 
    .custom /*0C000014:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2050
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 04   |                  */ ldarg.2
    IL_0003:  /* 28   | (06)000002       */ call       class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ System.Linq.Dynamic.DynamicQueryable/*02000002*/::Where(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/,
                                                                                                                                                                                 string,
                                                                                                                                                                                 object[]) /* 06000002 */
    IL_0008:  /* 74   | (1B)000002       */ castclass  class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T>/*1B000002*/
    IL_000d:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Where

  .method /*06000002*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          Where(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
                string predicate,
                object[] values) cil managed
  // SIG: 00 03 12 1D 12 1D 0E 1D 1C
  {
    .custom /*0C000011:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [3]/*08000006*/ 
    .custom /*0C000018:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2060
    // Code size       127 (0x7f)
    .maxstack  7
    .locals /*11000001*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 2D   | 0B               */ brtrue.s   IL_001c

    IL_0011:  /* 72   | (70)00000F       */ ldstr      "predicate" /* 7000000F */
    IL_0016:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_001b:  /* 7A   |                  */ throw

    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0022:  /* D0   | (01)000033       */ ldtoken    [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_0027:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_002c:  /* 03   |                  */ ldarg.1
    IL_002d:  /* 04   |                  */ ldarg.2
    IL_002e:  /* 28   | (06)000011       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000011 */
    IL_0033:  /* 0A   |                  */ stloc.0
    IL_0034:  /* 02   |                  */ ldarg.0
    IL_0035:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_003a:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_003f:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0044:  /* 72   | (70)000023       */ ldstr      "Where" /* 70000023 */
    IL_0049:  /* 17   |                  */ ldc.i4.1
    IL_004a:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_004f:  /* 0B   |                  */ stloc.1
    IL_0050:  /* 07   |                  */ ldloc.1
    IL_0051:  /* 16   |                  */ ldc.i4.0
    IL_0052:  /* 02   |                  */ ldarg.0
    IL_0053:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0058:  /* A2   |                  */ stelem.ref
    IL_0059:  /* 07   |                  */ ldloc.1
    IL_005a:  /* 18   |                  */ ldc.i4.2
    IL_005b:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0060:  /* 0C   |                  */ stloc.2
    IL_0061:  /* 08   |                  */ ldloc.2
    IL_0062:  /* 16   |                  */ ldc.i4.0
    IL_0063:  /* 02   |                  */ ldarg.0
    IL_0064:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0069:  /* A2   |                  */ stelem.ref
    IL_006a:  /* 08   |                  */ ldloc.2
    IL_006b:  /* 17   |                  */ ldc.i4.1
    IL_006c:  /* 06   |                  */ ldloc.0
    IL_006d:  /* 28   | (0A)000019       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Quote(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000019 */
    IL_0072:  /* A2   |                  */ stelem.ref
    IL_0073:  /* 08   |                  */ ldloc.2
    IL_0074:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_0079:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_007e:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Where

  .method /*06000003*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          Select(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
                 string selector,
                 object[] values) cil managed
  // SIG: 00 03 12 1D 12 1D 0E 1D 1C
  {
    .custom /*0C000013:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [3]/*08000009*/ 
    .custom /*0C00001C:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x20ec
    // Code size       132 (0x84)
    .maxstack  7
    .locals /*11000001*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 2D   | 0B               */ brtrue.s   IL_001c

    IL_0011:  /* 72   | (70)00002F       */ ldstr      "selector" /* 7000002F */
    IL_0016:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_001b:  /* 7A   |                  */ throw

    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0022:  /* 14   |                  */ ldnull
    IL_0023:  /* 03   |                  */ ldarg.1
    IL_0024:  /* 04   |                  */ ldarg.2
    IL_0025:  /* 28   | (06)000011       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000011 */
    IL_002a:  /* 0A   |                  */ stloc.0
    IL_002b:  /* 02   |                  */ ldarg.0
    IL_002c:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0031:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0036:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_003b:  /* 72   | (70)000041       */ ldstr      "Select" /* 70000041 */
    IL_0040:  /* 18   |                  */ ldc.i4.2
    IL_0041:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0046:  /* 0B   |                  */ stloc.1
    IL_0047:  /* 07   |                  */ ldloc.1
    IL_0048:  /* 16   |                  */ ldc.i4.0
    IL_0049:  /* 02   |                  */ ldarg.0
    IL_004a:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_004f:  /* A2   |                  */ stelem.ref
    IL_0050:  /* 07   |                  */ ldloc.1
    IL_0051:  /* 17   |                  */ ldc.i4.1
    IL_0052:  /* 06   |                  */ ldloc.0
    IL_0053:  /* 6F   | (0A)00001C       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/::get_Body() /* 0A00001C */
    IL_0058:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_005d:  /* A2   |                  */ stelem.ref
    IL_005e:  /* 07   |                  */ ldloc.1
    IL_005f:  /* 18   |                  */ ldc.i4.2
    IL_0060:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0065:  /* 0C   |                  */ stloc.2
    IL_0066:  /* 08   |                  */ ldloc.2
    IL_0067:  /* 16   |                  */ ldc.i4.0
    IL_0068:  /* 02   |                  */ ldarg.0
    IL_0069:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_006e:  /* A2   |                  */ stelem.ref
    IL_006f:  /* 08   |                  */ ldloc.2
    IL_0070:  /* 17   |                  */ ldc.i4.1
    IL_0071:  /* 06   |                  */ ldloc.0
    IL_0072:  /* 28   | (0A)000019       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Quote(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000019 */
    IL_0077:  /* A2   |                  */ stelem.ref
    IL_0078:  /* 08   |                  */ ldloc.2
    IL_0079:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_007e:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_0083:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Select

  .method /*06000004*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T> 
          OrderBy<T>(class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T> source,
                     string ordering,
                     object[] values) cil managed
  // SIG: 10 01 03 15 12 19 01 1E 00 15 12 19 01 1E 00 0E 1D 1C
  {
    .custom /*0C000015:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [3]/*0800000C*/ 
    .custom /*0C00001E:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x217c
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 04   |                  */ ldarg.2
    IL_0003:  /* 28   | (06)000005       */ call       class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ System.Linq.Dynamic.DynamicQueryable/*02000002*/::OrderBy(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/,
                                                                                                                                                                                   string,
                                                                                                                                                                                   object[]) /* 06000005 */
    IL_0008:  /* 74   | (1B)000002       */ castclass  class [System.Core/*23000002*/]System.Linq.IQueryable`1/*01000006*/<!!T>/*1B000002*/
    IL_000d:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::OrderBy

  .method /*06000005*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          OrderBy(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
                  string ordering,
                  object[] values) cil managed
  // SIG: 00 03 12 1D 12 1D 0E 1D 1C
  {
    .custom /*0C000016:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [3]/*0800000F*/ 
    .custom /*0C00001F:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x218c
    // Code size       272 (0x110)
    .maxstack  7
    .locals /*11000002*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] V_0,
             class System.Linq.Dynamic.ExpressionParser/*0200000A*/ V_1,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/> V_2,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_3,
             string V_4,
             string V_5,
             class System.Linq.Dynamic.DynamicOrdering/*02000006*/ V_6,
             class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] V_7,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/> V_8,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_9,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_10)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 2D   | 0B               */ brtrue.s   IL_001c

    IL_0011:  /* 72   | (70)00004F       */ ldstr      "ordering" /* 7000004F */
    IL_0016:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_001b:  /* 7A   |                  */ throw

    IL_001c:  /* 17   |                  */ ldc.i4.1
    IL_001d:  /* 8D   | (01)00000B       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/
    IL_0022:  /* 13   | 07               */ stloc.s    V_7
    IL_0024:  /* 11   | 07               */ ldloc.s    V_7
    IL_0026:  /* 16   |                  */ ldc.i4.0
    IL_0027:  /* 02   |                  */ ldarg.0
    IL_0028:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_002d:  /* 72   | (70)000061       */ ldstr      "" /* 70000061 */
    IL_0032:  /* 28   | (0A)00001E       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Parameter(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                 string) /* 0A00001E */
    IL_0037:  /* A2   |                  */ stelem.ref
    IL_0038:  /* 11   | 07               */ ldloc.s    V_7
    IL_003a:  /* 0A   |                  */ stloc.0
    IL_003b:  /* 06   |                  */ ldloc.0
    IL_003c:  /* 03   |                  */ ldarg.1
    IL_003d:  /* 04   |                  */ ldarg.2
    IL_003e:  /* 73   | (06)000025       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::.ctor(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[],
                                                                                                                             string,
                                                                                                                             object[]) /* 06000025 */
    IL_0043:  /* 0B   |                  */ stloc.1
    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 6F   | (06)00002A       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseOrdering() /* 0600002A */
    IL_004a:  /* 0C   |                  */ stloc.2
    IL_004b:  /* 02   |                  */ ldarg.0
    IL_004c:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0051:  /* 0D   |                  */ stloc.3
    IL_0052:  /* 72   | (70)000063       */ ldstr      "OrderBy" /* 70000063 */
    IL_0057:  /* 13   | 04               */ stloc.s    V_4
    IL_0059:  /* 72   | (70)000073       */ ldstr      "OrderByDescending" /* 70000073 */
    IL_005e:  /* 13   | 05               */ stloc.s    V_5
    IL_0060:  /* 08   |                  */ ldloc.2
    IL_0061:  /* 6F   | (0A)00001F       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/>/*1B000003*/::GetEnumerator() /* 0A00001F */
    IL_0066:  /* 13   | 08               */ stloc.s    V_8
    .try
    {
      IL_0068:  /* 2B   | 7F               */ br.s       IL_00e9

      IL_006a:  /* 11   | 08               */ ldloc.s    V_8
      IL_006c:  /* 6F   | (0A)000020       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/>/*1B000004*/::get_Current() /* 0A000020 */
      IL_0071:  /* 13   | 06               */ stloc.s    V_6
      IL_0073:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
      IL_0078:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
      IL_007d:  /* 11   | 06               */ ldloc.s    V_6
      IL_007f:  /* 7B   | (04)000004       */ ldfld      bool System.Linq.Dynamic.DynamicOrdering/*02000006*/::Ascending /* 04000004 */
      IL_0084:  /* 2D   | 04               */ brtrue.s   IL_008a

      IL_0086:  /* 11   | 05               */ ldloc.s    V_5
      IL_0088:  /* 2B   | 02               */ br.s       IL_008c

      IL_008a:  /* 11   | 04               */ ldloc.s    V_4
      IL_008c:  /* 18   |                  */ ldc.i4.2
      IL_008d:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
      IL_0092:  /* 13   | 09               */ stloc.s    V_9
      IL_0094:  /* 11   | 09               */ ldloc.s    V_9
      IL_0096:  /* 16   |                  */ ldc.i4.0
      IL_0097:  /* 02   |                  */ ldarg.0
      IL_0098:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
      IL_009d:  /* A2   |                  */ stelem.ref
      IL_009e:  /* 11   | 09               */ ldloc.s    V_9
      IL_00a0:  /* 17   |                  */ ldc.i4.1
      IL_00a1:  /* 11   | 06               */ ldloc.s    V_6
      IL_00a3:  /* 7B   | (04)000003       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.DynamicOrdering/*02000006*/::Selector /* 04000003 */
      IL_00a8:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
      IL_00ad:  /* A2   |                  */ stelem.ref
      IL_00ae:  /* 11   | 09               */ ldloc.s    V_9
      IL_00b0:  /* 18   |                  */ ldc.i4.2
      IL_00b1:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
      IL_00b6:  /* 13   | 0A               */ stloc.s    V_10
      IL_00b8:  /* 11   | 0A               */ ldloc.s    V_10
      IL_00ba:  /* 16   |                  */ ldc.i4.0
      IL_00bb:  /* 09   |                  */ ldloc.3
      IL_00bc:  /* A2   |                  */ stelem.ref
      IL_00bd:  /* 11   | 0A               */ ldloc.s    V_10
      IL_00bf:  /* 17   |                  */ ldc.i4.1
      IL_00c0:  /* 11   | 06               */ ldloc.s    V_6
      IL_00c2:  /* 7B   | (04)000003       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.DynamicOrdering/*02000006*/::Selector /* 04000003 */
      IL_00c7:  /* 06   |                  */ ldloc.0
      IL_00c8:  /* 28   | (0A)000021       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Lambda(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[]) /* 0A000021 */
      IL_00cd:  /* 28   | (0A)000019       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Quote(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000019 */
      IL_00d2:  /* A2   |                  */ stelem.ref
      IL_00d3:  /* 11   | 0A               */ ldloc.s    V_10
      IL_00d5:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                               string,
                                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
      IL_00da:  /* 0D   |                  */ stloc.3
      IL_00db:  /* 72   | (70)000097       */ ldstr      "ThenBy" /* 70000097 */
      IL_00e0:  /* 13   | 04               */ stloc.s    V_4
      IL_00e2:  /* 72   | (70)0000A5       */ ldstr      "ThenByDescending" /* 700000A5 */
      IL_00e7:  /* 13   | 05               */ stloc.s    V_5
      IL_00e9:  /* 11   | 08               */ ldloc.s    V_8
      IL_00eb:  /* 6F   | (0A)000022       */ callvirt   instance bool [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext() /* 0A000022 */
      IL_00f0:  /* 3A   | 75FFFFFF         */ brtrue     IL_006a

      IL_00f5:  /* DE   | 0C               */ leave.s    IL_0103

    }  // end .try
    finally
    {
      IL_00f7:  /* 11   | 08               */ ldloc.s    V_8
      IL_00f9:  /* 2C   | 07               */ brfalse.s  IL_0102

      IL_00fb:  /* 11   | 08               */ ldloc.s    V_8
      IL_00fd:  /* 6F   | (0A)000023       */ callvirt   instance void [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose() /* 0A000023 */
      IL_0102:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 68 00 8F F7 00 0C 00 00 00 00
    IL_0103:  /* 02   |                  */ ldarg.0
    IL_0104:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0109:  /* 09   |                  */ ldloc.3
    IL_010a:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_010f:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::OrderBy

  .method /*06000006*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          Take(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
               int32 count) cil managed
  // SIG: 00 02 12 1D 12 1D 08
  {
    .custom /*0C000017:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x22b8
    // Code size       94 (0x5e)
    .maxstack  7
    .locals /*11000003*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0014:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0019:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_001e:  /* 72   | (70)0000C7       */ ldstr      "Take" /* 700000C7 */
    IL_0023:  /* 17   |                  */ ldc.i4.1
    IL_0024:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0029:  /* 0A   |                  */ stloc.0
    IL_002a:  /* 06   |                  */ ldloc.0
    IL_002b:  /* 16   |                  */ ldc.i4.0
    IL_002c:  /* 02   |                  */ ldarg.0
    IL_002d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0032:  /* A2   |                  */ stelem.ref
    IL_0033:  /* 06   |                  */ ldloc.0
    IL_0034:  /* 18   |                  */ ldc.i4.2
    IL_0035:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_003a:  /* 0B   |                  */ stloc.1
    IL_003b:  /* 07   |                  */ ldloc.1
    IL_003c:  /* 16   |                  */ ldc.i4.0
    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0043:  /* A2   |                  */ stelem.ref
    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 17   |                  */ ldc.i4.1
    IL_0046:  /* 03   |                  */ ldarg.1
    IL_0047:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_004c:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0051:  /* A2   |                  */ stelem.ref
    IL_0052:  /* 07   |                  */ ldloc.1
    IL_0053:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_0058:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_005d:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Take

  .method /*06000007*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          Skip(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
               int32 count) cil managed
  // SIG: 00 02 12 1D 12 1D 08
  {
    .custom /*0C000019:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2324
    // Code size       94 (0x5e)
    .maxstack  7
    .locals /*11000003*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0014:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0019:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_001e:  /* 72   | (70)0000D1       */ ldstr      "Skip" /* 700000D1 */
    IL_0023:  /* 17   |                  */ ldc.i4.1
    IL_0024:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0029:  /* 0A   |                  */ stloc.0
    IL_002a:  /* 06   |                  */ ldloc.0
    IL_002b:  /* 16   |                  */ ldc.i4.0
    IL_002c:  /* 02   |                  */ ldarg.0
    IL_002d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0032:  /* A2   |                  */ stelem.ref
    IL_0033:  /* 06   |                  */ ldloc.0
    IL_0034:  /* 18   |                  */ ldc.i4.2
    IL_0035:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_003a:  /* 0B   |                  */ stloc.1
    IL_003b:  /* 07   |                  */ ldloc.1
    IL_003c:  /* 16   |                  */ ldc.i4.0
    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0043:  /* A2   |                  */ stelem.ref
    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 17   |                  */ ldc.i4.1
    IL_0046:  /* 03   |                  */ ldarg.1
    IL_0047:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_004c:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0051:  /* A2   |                  */ stelem.ref
    IL_0052:  /* 07   |                  */ ldloc.1
    IL_0053:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_0058:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_005d:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Skip

  .method /*06000008*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ 
          GroupBy(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source,
                  string keySelector,
                  string elementSelector,
                  object[] values) cil managed
  // SIG: 00 04 12 1D 12 1D 0E 0E 1D 1C
  {
    .custom /*0C00001A:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    .param [4]/*08000017*/ 
    .custom /*0C000020:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2390
    // Code size       184 (0xb8)
    .maxstack  7
    .locals /*11000004*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_2,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 2D   | 0B               */ brtrue.s   IL_001c

    IL_0011:  /* 72   | (70)0000DB       */ ldstr      "keySelector" /* 700000DB */
    IL_0016:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_001b:  /* 7A   |                  */ throw

    IL_001c:  /* 04   |                  */ ldarg.2
    IL_001d:  /* 2D   | 0B               */ brtrue.s   IL_002a

    IL_001f:  /* 72   | (70)0000F3       */ ldstr      "elementSelector" /* 700000F3 */
    IL_0024:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_0029:  /* 7A   |                  */ throw

    IL_002a:  /* 02   |                  */ ldarg.0
    IL_002b:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0030:  /* 14   |                  */ ldnull
    IL_0031:  /* 03   |                  */ ldarg.1
    IL_0032:  /* 05   |                  */ ldarg.3
    IL_0033:  /* 28   | (06)000011       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000011 */
    IL_0038:  /* 0A   |                  */ stloc.0
    IL_0039:  /* 02   |                  */ ldarg.0
    IL_003a:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_003f:  /* 14   |                  */ ldnull
    IL_0040:  /* 04   |                  */ ldarg.2
    IL_0041:  /* 05   |                  */ ldarg.3
    IL_0042:  /* 28   | (06)000011       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000011 */
    IL_0047:  /* 0B   |                  */ stloc.1
    IL_0048:  /* 02   |                  */ ldarg.0
    IL_0049:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_004e:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0053:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0058:  /* 72   | (70)000113       */ ldstr      "GroupBy" /* 70000113 */
    IL_005d:  /* 19   |                  */ ldc.i4.3
    IL_005e:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0063:  /* 0C   |                  */ stloc.2
    IL_0064:  /* 08   |                  */ ldloc.2
    IL_0065:  /* 16   |                  */ ldc.i4.0
    IL_0066:  /* 02   |                  */ ldarg.0
    IL_0067:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_006c:  /* A2   |                  */ stelem.ref
    IL_006d:  /* 08   |                  */ ldloc.2
    IL_006e:  /* 17   |                  */ ldc.i4.1
    IL_006f:  /* 06   |                  */ ldloc.0
    IL_0070:  /* 6F   | (0A)00001C       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/::get_Body() /* 0A00001C */
    IL_0075:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_007a:  /* A2   |                  */ stelem.ref
    IL_007b:  /* 08   |                  */ ldloc.2
    IL_007c:  /* 18   |                  */ ldc.i4.2
    IL_007d:  /* 07   |                  */ ldloc.1
    IL_007e:  /* 6F   | (0A)00001C       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/::get_Body() /* 0A00001C */
    IL_0083:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0088:  /* A2   |                  */ stelem.ref
    IL_0089:  /* 08   |                  */ ldloc.2
    IL_008a:  /* 19   |                  */ ldc.i4.3
    IL_008b:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0090:  /* 0D   |                  */ stloc.3
    IL_0091:  /* 09   |                  */ ldloc.3
    IL_0092:  /* 16   |                  */ ldc.i4.0
    IL_0093:  /* 02   |                  */ ldarg.0
    IL_0094:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0099:  /* A2   |                  */ stelem.ref
    IL_009a:  /* 09   |                  */ ldloc.3
    IL_009b:  /* 17   |                  */ ldc.i4.1
    IL_009c:  /* 06   |                  */ ldloc.0
    IL_009d:  /* 28   | (0A)000019       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Quote(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000019 */
    IL_00a2:  /* A2   |                  */ stelem.ref
    IL_00a3:  /* 09   |                  */ ldloc.3
    IL_00a4:  /* 18   |                  */ ldc.i4.2
    IL_00a5:  /* 07   |                  */ ldloc.1
    IL_00a6:  /* 28   | (0A)000019       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Quote(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000019 */
    IL_00ab:  /* A2   |                  */ stelem.ref
    IL_00ac:  /* 09   |                  */ ldloc.3
    IL_00ad:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_00b2:  /* 6F   | (0A)00001B       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::CreateQuery(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00001B */
    IL_00b7:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::GroupBy

  .method /*06000009*/ public hidebysig static 
          bool  Any(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source) cil managed
  // SIG: 00 01 02 12 1D
  {
    .custom /*0C00001B:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2454
    // Code size       85 (0x55)
    .maxstack  7
    .locals /*11000003*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0014:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0019:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_001e:  /* 72   | (70)000123       */ ldstr      "Any" /* 70000123 */
    IL_0023:  /* 17   |                  */ ldc.i4.1
    IL_0024:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0029:  /* 0A   |                  */ stloc.0
    IL_002a:  /* 06   |                  */ ldloc.0
    IL_002b:  /* 16   |                  */ ldc.i4.0
    IL_002c:  /* 02   |                  */ ldarg.0
    IL_002d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0032:  /* A2   |                  */ stelem.ref
    IL_0033:  /* 06   |                  */ ldloc.0
    IL_0034:  /* 17   |                  */ ldc.i4.1
    IL_0035:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_003a:  /* 0B   |                  */ stloc.1
    IL_003b:  /* 07   |                  */ ldloc.1
    IL_003c:  /* 16   |                  */ ldc.i4.0
    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0043:  /* A2   |                  */ stelem.ref
    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_004a:  /* 6F   | (0A)000025       */ callvirt   instance object [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::Execute(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000025 */
    IL_004f:  /* A5   | (01)000033       */ unbox.any  [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_0054:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Any

  .method /*0600000A*/ public hidebysig static 
          int32  Count(class [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/ source) cil managed
  // SIG: 00 01 08 12 1D
  {
    .custom /*0C00001D:0A000013*/ instance void [System.Core/*23000002*/]System.Runtime.CompilerServices.ExtensionAttribute/*01000031*/::.ctor() /* 0A000013 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x24b8
    // Code size       85 (0x55)
    .maxstack  7
    .locals /*11000003*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 2D   | 0B               */ brtrue.s   IL_000e

    IL_0003:  /* 72   | (70)000001       */ ldstr      "source" /* 70000001 */
    IL_0008:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_000d:  /* 7A   |                  */ throw

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 6F   | (0A)000017       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Provider() /* 0A000017 */
    IL_0014:  /* D0   | (01)000036       */ ldtoken    [System.Core/*23000002*/]System.Linq.Queryable/*01000036*/
    IL_0019:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_001e:  /* 72   | (70)00012B       */ ldstr      "Count" /* 7000012B */
    IL_0023:  /* 17   |                  */ ldc.i4.1
    IL_0024:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0029:  /* 0A   |                  */ stloc.0
    IL_002a:  /* 06   |                  */ ldloc.0
    IL_002b:  /* 16   |                  */ ldc.i4.0
    IL_002c:  /* 02   |                  */ ldarg.0
    IL_002d:  /* 6F   | (0A)000015       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_ElementType() /* 0A000015 */
    IL_0032:  /* A2   |                  */ stelem.ref
    IL_0033:  /* 06   |                  */ ldloc.0
    IL_0034:  /* 17   |                  */ ldc.i4.1
    IL_0035:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_003a:  /* 0B   |                  */ stloc.1
    IL_003b:  /* 07   |                  */ ldloc.1
    IL_003c:  /* 16   |                  */ ldc.i4.0
    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 6F   | (0A)000018       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ [System.Core/*23000002*/]System.Linq.IQueryable/*01000007*/::get_Expression() /* 0A000018 */
    IL_0043:  /* A2   |                  */ stelem.ref
    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_004a:  /* 6F   | (0A)000025       */ callvirt   instance object [System.Core/*23000002*/]System.Linq.IQueryProvider/*01000035*/::Execute(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000025 */
    IL_004f:  /* A5   | (01)00003C       */ unbox.any  [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0054:  /* 2A   |                  */ ret
  } // end of method DynamicQueryable::Count

} // end of class System.Linq.Dynamic.DynamicQueryable

.class /*02000003*/ public abstract auto ansi beforefieldinit System.Linq.Dynamic.DynamicClass
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .method /*0600000B*/ public hidebysig virtual 
          instance string  ToString() cil managed
  // SIG: 20 00 0E
  {
    // Method begins at RVA 0x251c
    // Code size       125 (0x7d)
    .maxstack  4
    .locals /*11000005*/ init (class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/[] V_0,
             class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ V_1,
             int32 V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)000026       */ call       instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Object/*01000001*/::GetType() /* 0A000026 */
    IL_0006:  /* 1F   | 14               */ ldc.i4.s   20
    IL_0008:  /* 6F   | (0A)000027       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetProperties(valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/) /* 0A000027 */
    IL_000d:  /* 0A   |                  */ stloc.0
    IL_000e:  /* 73   | (0A)000028       */ newobj     instance void [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::.ctor() /* 0A000028 */
    IL_0013:  /* 0B   |                  */ stloc.1
    IL_0014:  /* 07   |                  */ ldloc.1
    IL_0015:  /* 72   | (70)000137       */ ldstr      "{" /* 70000137 */
    IL_001a:  /* 6F   | (0A)000029       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(string) /* 0A000029 */
    IL_001f:  /* 26   |                  */ pop
    IL_0020:  /* 16   |                  */ ldc.i4.0
    IL_0021:  /* 0C   |                  */ stloc.2
    IL_0022:  /* 2B   | 40               */ br.s       IL_0064

    IL_0024:  /* 08   |                  */ ldloc.2
    IL_0025:  /* 16   |                  */ ldc.i4.0
    IL_0026:  /* 31   | 0C               */ ble.s      IL_0034

    IL_0028:  /* 07   |                  */ ldloc.1
    IL_0029:  /* 72   | (70)00013B       */ ldstr      ", " /* 7000013B */
    IL_002e:  /* 6F   | (0A)000029       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(string) /* 0A000029 */
    IL_0033:  /* 26   |                  */ pop
    IL_0034:  /* 07   |                  */ ldloc.1
    IL_0035:  /* 06   |                  */ ldloc.0
    IL_0036:  /* 08   |                  */ ldloc.2
    IL_0037:  /* 9A   |                  */ ldelem.ref
    IL_0038:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_003d:  /* 6F   | (0A)000029       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(string) /* 0A000029 */
    IL_0042:  /* 26   |                  */ pop
    IL_0043:  /* 07   |                  */ ldloc.1
    IL_0044:  /* 72   | (70)000141       */ ldstr      "=" /* 70000141 */
    IL_0049:  /* 6F   | (0A)000029       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(string) /* 0A000029 */
    IL_004e:  /* 26   |                  */ pop
    IL_004f:  /* 07   |                  */ ldloc.1
    IL_0050:  /* 06   |                  */ ldloc.0
    IL_0051:  /* 08   |                  */ ldloc.2
    IL_0052:  /* 9A   |                  */ ldelem.ref
    IL_0053:  /* 02   |                  */ ldarg.0
    IL_0054:  /* 14   |                  */ ldnull
    IL_0055:  /* 6F   | (0A)00002B       */ callvirt   instance object [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/::GetValue(object,
                                                                                                                                                  object[]) /* 0A00002B */
    IL_005a:  /* 6F   | (0A)00002C       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(object) /* 0A00002C */
    IL_005f:  /* 26   |                  */ pop
    IL_0060:  /* 08   |                  */ ldloc.2
    IL_0061:  /* 17   |                  */ ldc.i4.1
    IL_0062:  /* 58   |                  */ add
    IL_0063:  /* 0C   |                  */ stloc.2
    IL_0064:  /* 08   |                  */ ldloc.2
    IL_0065:  /* 06   |                  */ ldloc.0
    IL_0066:  /* 8E   |                  */ ldlen
    IL_0067:  /* 69   |                  */ conv.i4
    IL_0068:  /* 32   | BA               */ blt.s      IL_0024

    IL_006a:  /* 07   |                  */ ldloc.1
    IL_006b:  /* 72   | (70)000145       */ ldstr      "}" /* 70000145 */
    IL_0070:  /* 6F   | (0A)000029       */ callvirt   instance class [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/ [mscorlib/*23000001*/]System.Text.StringBuilder/*01000040*/::Append(string) /* 0A000029 */
    IL_0075:  /* 26   |                  */ pop
    IL_0076:  /* 07   |                  */ ldloc.1
    IL_0077:  /* 6F   | (0A)00002D       */ callvirt   instance string [mscorlib/*23000001*/]System.Object/*01000001*/::ToString() /* 0A00002D */
    IL_007c:  /* 2A   |                  */ ret
  } // end of method DynamicClass::ToString

  .method /*0600000C*/ family hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x25a5
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method DynamicClass::.ctor

} // end of class System.Linq.Dynamic.DynamicClass

.class /*02000004*/ public auto ansi beforefieldinit System.Linq.Dynamic.DynamicProperty
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .field /*04000001*/ private string name
  .field /*04000002*/ private class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type'
  .method /*0600000D*/ public hidebysig specialname rtspecialname 
          instance void  .ctor(string name,
                               class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 20 02 01 0E 12 21
  {
    // Method begins at RVA 0x25ad
    // Code size       55 (0x37)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 03   |                  */ ldarg.1
    IL_0007:  /* 2D   | 0B               */ brtrue.s   IL_0014

    IL_0009:  /* 72   | (70)000149       */ ldstr      "name" /* 70000149 */
    IL_000e:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_0013:  /* 7A   |                  */ throw

    IL_0014:  /* 04   |                  */ ldarg.2
    IL_0015:  /* 14   |                  */ ldnull
    IL_0016:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_001b:  /* 2C   | 0B               */ brfalse.s  IL_0028

    IL_001d:  /* 72   | (70)000153       */ ldstr      "type" /* 70000153 */
    IL_0022:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_0027:  /* 7A   |                  */ throw

    IL_0028:  /* 02   |                  */ ldarg.0
    IL_0029:  /* 03   |                  */ ldarg.1
    IL_002a:  /* 7D   | (04)000001       */ stfld      string System.Linq.Dynamic.DynamicProperty/*02000004*/::name /* 04000001 */
    IL_002f:  /* 02   |                  */ ldarg.0
    IL_0030:  /* 04   |                  */ ldarg.2
    IL_0031:  /* 7D   | (04)000002       */ stfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::'type' /* 04000002 */
    IL_0036:  /* 2A   |                  */ ret
  } // end of method DynamicProperty::.ctor

  .method /*0600000E*/ public hidebysig specialname 
          instance string  get_Name() cil managed
  // SIG: 20 00 0E
  {
    // Method begins at RVA 0x25e5
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000001       */ ldfld      string System.Linq.Dynamic.DynamicProperty/*02000004*/::name /* 04000001 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method DynamicProperty::get_Name

  .method /*0600000F*/ public hidebysig specialname 
          instance class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          get_Type() cil managed
  // SIG: 20 00 12 21
  {
    // Method begins at RVA 0x25ed
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000002       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::'type' /* 04000002 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method DynamicProperty::get_Type

  .property /*17000001*/ instance string Name()
  {
    .get instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
  } // end of property DynamicProperty::Name
  .property /*17000002*/ instance class [mscorlib/*23000001*/]System.Type/*01000008*/
          Type()
  {
    .get instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
  } // end of property DynamicProperty::Type
} // end of class System.Linq.Dynamic.DynamicProperty

.class /*02000005*/ public abstract auto ansi sealed beforefieldinit System.Linq.Dynamic.DynamicExpression
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .method /*06000010*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          Parse(class [mscorlib/*23000001*/]System.Type/*01000008*/ resultType,
                string expression,
                object[] values) cil managed
  // SIG: 00 03 12 25 12 21 0E 1D 1C
  {
    .param [3]/*0800001E*/ 
    .custom /*0C000024:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x25f8
    // Code size       17 (0x11)
    .maxstack  4
    .locals /*11000006*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*/ V_0)
    IL_0000:  /* 14   |                  */ ldnull
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 04   |                  */ ldarg.2
    IL_0003:  /* 73   | (06)000025       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::.ctor(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[],
                                                                                                                             string,
                                                                                                                             object[]) /* 06000025 */
    IL_0008:  /* 0A   |                  */ stloc.0
    IL_0009:  /* 06   |                  */ ldloc.0
    IL_000a:  /* 02   |                  */ ldarg.0
    IL_000b:  /* 6F   | (06)000029       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::Parse(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000029 */
    IL_0010:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::Parse

  .method /*06000011*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ 
          ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/ itType,
                      class [mscorlib/*23000001*/]System.Type/*01000008*/ resultType,
                      string expression,
                      object[] values) cil managed
  // SIG: 00 04 12 29 12 21 12 21 0E 1D 1C
  {
    .param [4]/*08000022*/ 
    .custom /*0C000027:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2618
    // Code size       31 (0x1f)
    .maxstack  4
    .locals /*11000007*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] V_0)
    IL_0000:  /* 17   |                  */ ldc.i4.1
    IL_0001:  /* 8D   | (01)00000B       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 06   |                  */ ldloc.0
    IL_0008:  /* 16   |                  */ ldc.i4.0
    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 72   | (70)000061       */ ldstr      "" /* 70000061 */
    IL_000f:  /* 28   | (0A)00001E       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Parameter(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                 string) /* 0A00001E */
    IL_0014:  /* A2   |                  */ stelem.ref
    IL_0015:  /* 06   |                  */ ldloc.0
    IL_0016:  /* 03   |                  */ ldarg.1
    IL_0017:  /* 04   |                  */ ldarg.2
    IL_0018:  /* 05   |                  */ ldarg.3
    IL_0019:  /* 28   | (06)000012       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[],
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000012 */
    IL_001e:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::ParseLambda

  .method /*06000012*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ 
          ParseLambda(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] parameters,
                      class [mscorlib/*23000001*/]System.Type/*01000008*/ resultType,
                      string expression,
                      object[] values) cil managed
  // SIG: 00 04 12 29 1D 12 2D 12 21 0E 1D 1C
  {
    .param [4]/*08000026*/ 
    .custom /*0C000028:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2644
    // Code size       23 (0x17)
    .maxstack  4
    .locals /*11000006*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*/ V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 04   |                  */ ldarg.2
    IL_0002:  /* 05   |                  */ ldarg.3
    IL_0003:  /* 73   | (06)000025       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::.ctor(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[],
                                                                                                                             string,
                                                                                                                             object[]) /* 06000025 */
    IL_0008:  /* 0A   |                  */ stloc.0
    IL_0009:  /* 06   |                  */ ldloc.0
    IL_000a:  /* 03   |                  */ ldarg.1
    IL_000b:  /* 6F   | (06)000029       */ callvirt   instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::Parse(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000029 */
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 28   | (0A)000021       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Lambda(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[]) /* 0A000021 */
    IL_0016:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::ParseLambda

  .method /*06000013*/ public hidebysig static 
          class [System.Core/*23000002*/]System.Linq.Expressions.Expression`1/*0100000C*/<class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!T,!!S>> 
          ParseLambda<T,S>(string expression,
                           object[] values) cil managed
  // SIG: 10 02 02 15 12 31 01 15 12 35 02 1E 00 1E 01 0E 1D 1C
  {
    .param [2]/*08000028*/ 
    .custom /*0C000029:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2667
    // Code size       33 (0x21)
    .maxstack  8
    IL_0000:  /* D0   | (1B)000005       */ ldtoken    !!T/*1B000005*/
    IL_0005:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_000a:  /* D0   | (1B)000006       */ ldtoken    !!S/*1B000006*/
    IL_000f:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0014:  /* 02   |                  */ ldarg.0
    IL_0015:  /* 03   |                  */ ldarg.1
    IL_0016:  /* 28   | (06)000011       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::ParseLambda(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                          string,
                                                                                                                                                                                                          object[]) /* 06000011 */
    IL_001b:  /* 74   | (1B)000007       */ castclass  class [System.Core/*23000002*/]System.Linq.Expressions.Expression`1/*0100000C*/<class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!T,!!S>>/*1B000007*/
    IL_0020:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::ParseLambda

  .method /*06000014*/ public hidebysig static 
          class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          CreateClass(class System.Linq.Dynamic.DynamicProperty/*02000004*/[] properties) cil managed
  // SIG: 00 01 12 21 1D 12 10
  {
    .param [1]/*08000029*/ 
    .custom /*0C00002A:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x2689
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  /* 7E   | (04)000007       */ ldsfld     class System.Linq.Dynamic.ClassFactory/*02000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::Instance /* 04000007 */
    IL_0005:  /* 02   |                  */ ldarg.0
    IL_0006:  /* 6F   | (06)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::GetDynamicClass(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>) /* 0600001D */
    IL_000b:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::CreateClass

  .method /*06000015*/ public hidebysig static 
          class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          CreateClass(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/> properties) cil managed
  // SIG: 00 01 12 21 15 12 39 01 12 10
  {
    // Method begins at RVA 0x2696
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  /* 7E   | (04)000007       */ ldsfld     class System.Linq.Dynamic.ClassFactory/*02000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::Instance /* 04000007 */
    IL_0005:  /* 02   |                  */ ldarg.0
    IL_0006:  /* 6F   | (06)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::GetDynamicClass(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>) /* 0600001D */
    IL_000b:  /* 2A   |                  */ ret
  } // end of method DynamicExpression::CreateClass

} // end of class System.Linq.Dynamic.DynamicExpression

.class /*02000006*/ private auto ansi beforefieldinit System.Linq.Dynamic.DynamicOrdering
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .field /*04000003*/ public class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ Selector
  .field /*04000004*/ public bool Ascending
  .method /*06000016*/ public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x26a3
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method DynamicOrdering::.ctor

} // end of class System.Linq.Dynamic.DynamicOrdering

.class /*02000007*/ private auto ansi beforefieldinit System.Linq.Dynamic.Signature
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
       implements class [mscorlib/*23000001*/]System.IEquatable`1/*01000002*/<class System.Linq.Dynamic.Signature/*02000007*/>/*1B000001*/
{
  .field /*04000005*/ public class System.Linq.Dynamic.DynamicProperty/*02000004*/[] properties
  .field /*04000006*/ public int32 hashCode
  .method /*06000017*/ public hidebysig specialname rtspecialname 
          instance void  .ctor(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/> properties) cil managed
  // SIG: 20 01 01 15 12 39 01 12 10
  {
    // Method begins at RVA 0x26ac
    // Code size       98 (0x62)
    .maxstack  4
    .locals /*11000008*/ init (class System.Linq.Dynamic.DynamicProperty/*02000004*/ V_0,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/> V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 02   |                  */ ldarg.0
    IL_0007:  /* 03   |                  */ ldarg.1
    IL_0008:  /* 28   | (2B)000001       */ call       !!0[] [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::ToArray<class System.Linq.Dynamic.DynamicProperty/*02000004*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>) /* 2B000001 */
    IL_000d:  /* 7D   | (04)000005       */ stfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 16   |                  */ ldc.i4.0
    IL_0014:  /* 7D   | (04)000006       */ stfld      int32 System.Linq.Dynamic.Signature/*02000007*/::hashCode /* 04000006 */
    IL_0019:  /* 03   |                  */ ldarg.1
    IL_001a:  /* 6F   | (0A)000031       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B000008*/::GetEnumerator() /* 0A000031 */
    IL_001f:  /* 0B   |                  */ stloc.1
    .try
    {
      IL_0020:  /* 2B   | 2B               */ br.s       IL_004d

      IL_0022:  /* 07   |                  */ ldloc.1
      IL_0023:  /* 6F   | (0A)000032       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B000009*/::get_Current() /* 0A000032 */
      IL_0028:  /* 0A   |                  */ stloc.0
      IL_0029:  /* 02   |                  */ ldarg.0
      IL_002a:  /* 25   |                  */ dup
      IL_002b:  /* 7B   | (04)000006       */ ldfld      int32 System.Linq.Dynamic.Signature/*02000007*/::hashCode /* 04000006 */
      IL_0030:  /* 06   |                  */ ldloc.0
      IL_0031:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
      IL_0036:  /* 6F   | (0A)000033       */ callvirt   instance int32 [mscorlib/*23000001*/]System.Object/*01000001*/::GetHashCode() /* 0A000033 */
      IL_003b:  /* 06   |                  */ ldloc.0
      IL_003c:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
      IL_0041:  /* 6F   | (0A)000033       */ callvirt   instance int32 [mscorlib/*23000001*/]System.Object/*01000001*/::GetHashCode() /* 0A000033 */
      IL_0046:  /* 61   |                  */ xor
      IL_0047:  /* 61   |                  */ xor
      IL_0048:  /* 7D   | (04)000006       */ stfld      int32 System.Linq.Dynamic.Signature/*02000007*/::hashCode /* 04000006 */
      IL_004d:  /* 07   |                  */ ldloc.1
      IL_004e:  /* 6F   | (0A)000022       */ callvirt   instance bool [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext() /* 0A000022 */
      IL_0053:  /* 2D   | CD               */ brtrue.s   IL_0022

      IL_0055:  /* DE   | 0A               */ leave.s    IL_0061

    }  // end .try
    finally
    {
      IL_0057:  /* 07   |                  */ ldloc.1
      IL_0058:  /* 2C   | 06               */ brfalse.s  IL_0060

      IL_005a:  /* 07   |                  */ ldloc.1
      IL_005b:  /* 6F   | (0A)000023       */ callvirt   instance void [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose() /* 0A000023 */
      IL_0060:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 20 00 37 57 00 0A 00 00 00 00
    IL_0061:  /* 2A   |                  */ ret
  } // end of method Signature::.ctor

  .method /*06000018*/ public hidebysig virtual 
          instance int32  GetHashCode() cil managed
  // SIG: 20 00 08
  {
    // Method begins at RVA 0x272c
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000006       */ ldfld      int32 System.Linq.Dynamic.Signature/*02000007*/::hashCode /* 04000006 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method Signature::GetHashCode

  .method /*06000019*/ public hidebysig virtual 
          instance bool  Equals(object obj) cil managed
  // SIG: 20 01 02 1C
  {
    // Method begins at RVA 0x2734
    // Code size       23 (0x17)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 75   | (02)000007       */ isinst     System.Linq.Dynamic.Signature/*02000007*/
    IL_0006:  /* 2D   | 02               */ brtrue.s   IL_000a

    IL_0008:  /* 16   |                  */ ldc.i4.0
    IL_0009:  /* 2A   |                  */ ret

    IL_000a:  /* 02   |                  */ ldarg.0
    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 74   | (02)000007       */ castclass  System.Linq.Dynamic.Signature/*02000007*/
    IL_0011:  /* 28   | (06)00001A       */ call       instance bool System.Linq.Dynamic.Signature/*02000007*/::Equals(class System.Linq.Dynamic.Signature/*02000007*/) /* 0600001A */
    IL_0016:  /* 2A   |                  */ ret
  } // end of method Signature::Equals

  .method /*0600001A*/ public hidebysig newslot virtual final 
          instance bool  Equals(class System.Linq.Dynamic.Signature/*02000007*/ other) cil managed
  // SIG: 20 01 02 12 1C
  {
    // Method begins at RVA 0x274c
    // Code size       109 (0x6d)
    .maxstack  3
    .locals /*11000009*/ init (int32 V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_0006:  /* 8E   |                  */ ldlen
    IL_0007:  /* 69   |                  */ conv.i4
    IL_0008:  /* 03   |                  */ ldarg.1
    IL_0009:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_000e:  /* 8E   |                  */ ldlen
    IL_000f:  /* 69   |                  */ conv.i4
    IL_0010:  /* 2E   | 02               */ beq.s      IL_0014

    IL_0012:  /* 16   |                  */ ldc.i4.0
    IL_0013:  /* 2A   |                  */ ret

    IL_0014:  /* 16   |                  */ ldc.i4.0
    IL_0015:  /* 0A   |                  */ stloc.0
    IL_0016:  /* 2B   | 48               */ br.s       IL_0060

    IL_0018:  /* 02   |                  */ ldarg.0
    IL_0019:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_001e:  /* 06   |                  */ ldloc.0
    IL_001f:  /* 9A   |                  */ ldelem.ref
    IL_0020:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_0025:  /* 03   |                  */ ldarg.1
    IL_0026:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_002b:  /* 06   |                  */ ldloc.0
    IL_002c:  /* 9A   |                  */ ldelem.ref
    IL_002d:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_0032:  /* 28   | (0A)000034       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::op_Inequality(string,
                                                                                                                           string) /* 0A000034 */
    IL_0037:  /* 2D   | 21               */ brtrue.s   IL_005a

    IL_0039:  /* 02   |                  */ ldarg.0
    IL_003a:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_003f:  /* 06   |                  */ ldloc.0
    IL_0040:  /* 9A   |                  */ ldelem.ref
    IL_0041:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_0046:  /* 03   |                  */ ldarg.1
    IL_0047:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_004c:  /* 06   |                  */ ldloc.0
    IL_004d:  /* 9A   |                  */ ldelem.ref
    IL_004e:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_0053:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0058:  /* 2C   | 02               */ brfalse.s  IL_005c

    IL_005a:  /* 16   |                  */ ldc.i4.0
    IL_005b:  /* 2A   |                  */ ret

    IL_005c:  /* 06   |                  */ ldloc.0
    IL_005d:  /* 17   |                  */ ldc.i4.1
    IL_005e:  /* 58   |                  */ add
    IL_005f:  /* 0A   |                  */ stloc.0
    IL_0060:  /* 06   |                  */ ldloc.0
    IL_0061:  /* 02   |                  */ ldarg.0
    IL_0062:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
    IL_0067:  /* 8E   |                  */ ldlen
    IL_0068:  /* 69   |                  */ conv.i4
    IL_0069:  /* 32   | AD               */ blt.s      IL_0018

    IL_006b:  /* 17   |                  */ ldc.i4.1
    IL_006c:  /* 2A   |                  */ ret
  } // end of method Signature::Equals

} // end of class System.Linq.Dynamic.Signature

.class /*02000008*/ private auto ansi System.Linq.Dynamic.ClassFactory
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .field /*04000007*/ public static initonly class System.Linq.Dynamic.ClassFactory/*02000008*/ Instance
  .field /*04000008*/ private class [mscorlib/*23000001*/]System.Reflection.Emit.ModuleBuilder/*0100000F*/ module
  .field /*04000009*/ private class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/> classes
  .field /*0400000A*/ private int32 classCount
  .field /*0400000B*/ private class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ rwLock
  .method /*0600001B*/ private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  // SIG: 00 00 01
  {
    // Method begins at RVA 0x27c5
    // Code size       11 (0xb)
    .maxstack  8
    IL_0000:  /* 73   | (06)00001C       */ newobj     instance void System.Linq.Dynamic.ClassFactory/*02000008*/::.ctor() /* 0600001C */
    IL_0005:  /* 80   | (04)000007       */ stsfld     class System.Linq.Dynamic.ClassFactory/*02000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::Instance /* 04000007 */
    IL_000a:  /* 2A   |                  */ ret
  } // end of method ClassFactory::.cctor

  .method /*0600001C*/ private hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x27d4
    // Code size       70 (0x46)
    .maxstack  3
    .locals /*1100000A*/ init (class [mscorlib/*23000001*/]System.Reflection.AssemblyName/*01000043*/ V_0,
             class [mscorlib/*23000001*/]System.Reflection.Emit.AssemblyBuilder/*01000045*/ V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 72   | (70)00015D       */ ldstr      "DynamicClasses" /* 7000015D */
    IL_000b:  /* 73   | (0A)000036       */ newobj     instance void [mscorlib/*23000001*/]System.Reflection.AssemblyName/*01000043*/::.ctor(string) /* 0A000036 */
    IL_0010:  /* 0A   |                  */ stloc.0
    IL_0011:  /* 28   | (0A)000037       */ call       class [mscorlib/*23000001*/]System.AppDomain/*01000044*/ [mscorlib/*23000001*/]System.AppDomain/*01000044*/::get_CurrentDomain() /* 0A000037 */
    IL_0016:  /* 06   |                  */ ldloc.0
    IL_0017:  /* 17   |                  */ ldc.i4.1
    IL_0018:  /* 6F   | (0A)000038       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.AssemblyBuilder/*01000045*/ [mscorlib/*23000001*/]System.AppDomain/*01000044*/::DefineDynamicAssembly(class [mscorlib/*23000001*/]System.Reflection.AssemblyName/*01000043*/,
                                                                                                                                                                                                                         valuetype [mscorlib/*23000001*/]System.Reflection.Emit.AssemblyBuilderAccess/*01000046*/) /* 0A000038 */
    IL_001d:  /* 0B   |                  */ stloc.1
    IL_001e:  /* 02   |                  */ ldarg.0
    IL_001f:  /* 07   |                  */ ldloc.1
    IL_0020:  /* 72   | (70)00017B       */ ldstr      "Module" /* 7000017B */
    IL_0025:  /* 6F   | (0A)000039       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.ModuleBuilder/*0100000F*/ [mscorlib/*23000001*/]System.Reflection.Emit.AssemblyBuilder/*01000045*/::DefineDynamicModule(string) /* 0A000039 */
    IL_002a:  /* 7D   | (04)000008       */ stfld      class [mscorlib/*23000001*/]System.Reflection.Emit.ModuleBuilder/*0100000F*/ System.Linq.Dynamic.ClassFactory/*02000008*/::module /* 04000008 */
    IL_002f:  /* 02   |                  */ ldarg.0
    IL_0030:  /* 73   | (0A)00003A       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B00000A*/::.ctor() /* 0A00003A */
    IL_0035:  /* 7D   | (04)000009       */ stfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ClassFactory/*02000008*/::classes /* 04000009 */
    IL_003a:  /* 02   |                  */ ldarg.0
    IL_003b:  /* 73   | (0A)00003B       */ newobj     instance void [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/::.ctor() /* 0A00003B */
    IL_0040:  /* 7D   | (04)00000B       */ stfld      class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ System.Linq.Dynamic.ClassFactory/*02000008*/::rwLock /* 0400000B */
    IL_0045:  /* 2A   |                  */ ret
  } // end of method ClassFactory::.ctor

  .method /*0600001D*/ public hidebysig instance class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          GetDynamicClass(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/> properties) cil managed
  // SIG: 20 01 12 21 15 12 39 01 12 10
  {
    // Method begins at RVA 0x2828
    // Code size       79 (0x4f)
    .maxstack  3
    .locals /*1100000B*/ init (class System.Linq.Dynamic.Signature/*02000007*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)00000B       */ ldfld      class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ System.Linq.Dynamic.ClassFactory/*02000008*/::rwLock /* 0400000B */
    IL_0006:  /* 15   |                  */ ldc.i4.m1
    IL_0007:  /* 6F   | (0A)00003C       */ callvirt   instance void [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/::AcquireReaderLock(int32) /* 0A00003C */
    .try
    {
      IL_000c:  /* 03   |                  */ ldarg.1
      IL_000d:  /* 73   | (06)000017       */ newobj     instance void System.Linq.Dynamic.Signature/*02000007*/::.ctor(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>) /* 06000017 */
      IL_0012:  /* 0A   |                  */ stloc.0
      IL_0013:  /* 02   |                  */ ldarg.0
      IL_0014:  /* 7B   | (04)000009       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ClassFactory/*02000008*/::classes /* 04000009 */
      IL_0019:  /* 06   |                  */ ldloc.0
      IL_001a:  /* 12   | 01               */ ldloca.s   V_1
      IL_001c:  /* 6F   | (0A)00003D       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B00000A*/::TryGetValue(!0,
                                                                                                                                                                                                                                                                                     !1&) /* 0A00003D */
      IL_0021:  /* 2D   | 1A               */ brtrue.s   IL_003d

      IL_0023:  /* 02   |                  */ ldarg.0
      IL_0024:  /* 06   |                  */ ldloc.0
      IL_0025:  /* 7B   | (04)000005       */ ldfld      class System.Linq.Dynamic.DynamicProperty/*02000004*/[] System.Linq.Dynamic.Signature/*02000007*/::properties /* 04000005 */
      IL_002a:  /* 28   | (06)00001E       */ call       instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ClassFactory/*02000008*/::CreateDynamicClass(class System.Linq.Dynamic.DynamicProperty/*02000004*/[]) /* 0600001E */
      IL_002f:  /* 0B   |                  */ stloc.1
      IL_0030:  /* 02   |                  */ ldarg.0
      IL_0031:  /* 7B   | (04)000009       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ClassFactory/*02000008*/::classes /* 04000009 */
      IL_0036:  /* 06   |                  */ ldloc.0
      IL_0037:  /* 07   |                  */ ldloc.1
      IL_0038:  /* 6F   | (0A)00003E       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class System.Linq.Dynamic.Signature/*02000007*/,class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B00000A*/::Add(!0,
                                                                                                                                                                                                                                                                             !1) /* 0A00003E */
      IL_003d:  /* 07   |                  */ ldloc.1
      IL_003e:  /* 0C   |                  */ stloc.2
      IL_003f:  /* DE   | 0C               */ leave.s    IL_004d

    }  // end .try
    finally
    {
      IL_0041:  /* 02   |                  */ ldarg.0
      IL_0042:  /* 7B   | (04)00000B       */ ldfld      class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ System.Linq.Dynamic.ClassFactory/*02000008*/::rwLock /* 0400000B */
      IL_0047:  /* 6F   | (0A)00003F       */ callvirt   instance void [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/::ReleaseReaderLock() /* 0A00003F */
      IL_004c:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 0C 00 35 41 00 0C 00 00 00 00
    IL_004d:  /* 08   |                  */ ldloc.2
    IL_004e:  /* 2A   |                  */ ret
  } // end of method ClassFactory::GetDynamicClass

  .method /*0600001E*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          CreateDynamicClass(class System.Linq.Dynamic.DynamicProperty/*02000004*/[] properties) cil managed
  // SIG: 20 01 12 21 1D 12 10
  {
    // Method begins at RVA 0x2894
    // Code size       131 (0x83)
    .maxstack  4
    .locals /*1100000C*/ init (valuetype [mscorlib/*23000001*/]System.Threading.LockCookie/*01000047*/ V_0,
             string V_1,
             class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/ V_2,
             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] V_3,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_4,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_5)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)00000B       */ ldfld      class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ System.Linq.Dynamic.ClassFactory/*02000008*/::rwLock /* 0400000B */
    IL_0006:  /* 15   |                  */ ldc.i4.m1
    IL_0007:  /* 6F   | (0A)000040       */ callvirt   instance valuetype [mscorlib/*23000001*/]System.Threading.LockCookie/*01000047*/ [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/::UpgradeToWriterLock(int32) /* 0A000040 */
    IL_000c:  /* 0A   |                  */ stloc.0
    .try
    {
      IL_000d:  /* 72   | (70)000189       */ ldstr      "DynamicClass" /* 70000189 */
      IL_0012:  /* 02   |                  */ ldarg.0
      IL_0013:  /* 7B   | (04)00000A       */ ldfld      int32 System.Linq.Dynamic.ClassFactory/*02000008*/::classCount /* 0400000A */
      IL_0018:  /* 17   |                  */ ldc.i4.1
      IL_0019:  /* 58   |                  */ add
      IL_001a:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
      IL_001f:  /* 28   | (0A)000041       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(object,
                                                                                                                        object) /* 0A000041 */
      IL_0024:  /* 0B   |                  */ stloc.1
      IL_0025:  /* 02   |                  */ ldarg.0
      IL_0026:  /* 7B   | (04)000008       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.Emit.ModuleBuilder/*0100000F*/ System.Linq.Dynamic.ClassFactory/*02000008*/::module /* 04000008 */
      IL_002b:  /* 07   |                  */ ldloc.1
      IL_002c:  /* 17   |                  */ ldc.i4.1
      IL_002d:  /* D0   | (02)000003       */ ldtoken    System.Linq.Dynamic.DynamicClass/*02000003*/
      IL_0032:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
      IL_0037:  /* 6F   | (0A)000042       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/ [mscorlib/*23000001*/]System.Reflection.Emit.ModuleBuilder/*0100000F*/::DefineType(string,
                                                                                                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.TypeAttributes/*01000048*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000042 */
      IL_003c:  /* 0C   |                  */ stloc.2
      IL_003d:  /* 02   |                  */ ldarg.0
      IL_003e:  /* 08   |                  */ ldloc.2
      IL_003f:  /* 03   |                  */ ldarg.1
      IL_0040:  /* 28   | (06)00001F       */ call       instance class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] System.Linq.Dynamic.ClassFactory/*02000008*/::GenerateProperties(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/,
                                                                                                                                                                                                         class System.Linq.Dynamic.DynamicProperty/*02000004*/[]) /* 0600001F */
      IL_0045:  /* 0D   |                  */ stloc.3
      IL_0046:  /* 02   |                  */ ldarg.0
      IL_0047:  /* 08   |                  */ ldloc.2
      IL_0048:  /* 09   |                  */ ldloc.3
      IL_0049:  /* 28   | (06)000020       */ call       instance void System.Linq.Dynamic.ClassFactory/*02000008*/::GenerateEquals(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/,
                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[]) /* 06000020 */
      IL_004e:  /* 02   |                  */ ldarg.0
      IL_004f:  /* 08   |                  */ ldloc.2
      IL_0050:  /* 09   |                  */ ldloc.3
      IL_0051:  /* 28   | (06)000021       */ call       instance void System.Linq.Dynamic.ClassFactory/*02000008*/::GenerateGetHashCode(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/,
                                                                                                                                         class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[]) /* 06000021 */
      IL_0056:  /* 08   |                  */ ldloc.2
      IL_0057:  /* 6F   | (0A)000043       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::CreateType() /* 0A000043 */
      IL_005c:  /* 13   | 04               */ stloc.s    V_4
      IL_005e:  /* 02   |                  */ ldarg.0
      IL_005f:  /* 25   |                  */ dup
      IL_0060:  /* 7B   | (04)00000A       */ ldfld      int32 System.Linq.Dynamic.ClassFactory/*02000008*/::classCount /* 0400000A */
      IL_0065:  /* 17   |                  */ ldc.i4.1
      IL_0066:  /* 58   |                  */ add
      IL_0067:  /* 7D   | (04)00000A       */ stfld      int32 System.Linq.Dynamic.ClassFactory/*02000008*/::classCount /* 0400000A */
      IL_006c:  /* 11   | 04               */ ldloc.s    V_4
      IL_006e:  /* 13   | 05               */ stloc.s    V_5
      IL_0070:  /* DE   | 0E               */ leave.s    IL_0080

    }  // end .try
    finally
    {
      IL_0072:  /* 02   |                  */ ldarg.0
      IL_0073:  /* 7B   | (04)00000B       */ ldfld      class [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/ System.Linq.Dynamic.ClassFactory/*02000008*/::rwLock /* 0400000B */
      IL_0078:  /* 12   | 00               */ ldloca.s   V_0
      IL_007a:  /* 6F   | (0A)000044       */ callvirt   instance void [mscorlib/*23000001*/]System.Threading.ReaderWriterLock/*01000011*/::DowngradeFromWriterLock(valuetype [mscorlib/*23000001*/]System.Threading.LockCookie/*01000047*/&) /* 0A000044 */
      IL_007f:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 0D 00 65 72 00 0E 00 00 00 00
    IL_0080:  /* 11   | 05               */ ldloc.s    V_5
    IL_0082:  /* 2A   |                  */ ret
  } // end of method ClassFactory::CreateDynamicClass

  .method /*0600001F*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] 
          GenerateProperties(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/ tb,
                             class System.Linq.Dynamic.DynamicProperty/*02000004*/[] properties) cil managed
  // SIG: 20 02 1D 12 49 12 4D 1D 12 10
  {
    // Method begins at RVA 0x2934
    // Code size       307 (0x133)
    .maxstack  7
    .locals /*1100000D*/ init (class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] V_0,
             int32 V_1,
             class System.Linq.Dynamic.DynamicProperty/*02000004*/ V_2,
             class [mscorlib/*23000001*/]System.Reflection.Emit.FieldBuilder/*01000049*/ V_3,
             class [mscorlib/*23000001*/]System.Reflection.Emit.PropertyBuilder/*0100004B*/ V_4,
             class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ V_5,
             class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ V_6,
             class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ V_7,
             class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ V_8,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_9)
    IL_0000:  /* 04   |                  */ ldarg.2
    IL_0001:  /* 8E   |                  */ ldlen
    IL_0002:  /* 69   |                  */ conv.i4
    IL_0003:  /* 8D   | (01)000049       */ newarr     [mscorlib/*23000001*/]System.Reflection.Emit.FieldBuilder/*01000049*/
    IL_0008:  /* 0A   |                  */ stloc.0
    IL_0009:  /* 16   |                  */ ldc.i4.0
    IL_000a:  /* 0B   |                  */ stloc.1
    IL_000b:  /* 38   | 18010000         */ br         IL_0128

    IL_0010:  /* 04   |                  */ ldarg.2
    IL_0011:  /* 07   |                  */ ldloc.1
    IL_0012:  /* 9A   |                  */ ldelem.ref
    IL_0013:  /* 0C   |                  */ stloc.2
    IL_0014:  /* 03   |                  */ ldarg.1
    IL_0015:  /* 72   | (70)0001A3       */ ldstr      "_" /* 700001A3 */
    IL_001a:  /* 08   |                  */ ldloc.2
    IL_001b:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_0020:  /* 28   | (0A)000045       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(string,
                                                                                                                      string) /* 0A000045 */
    IL_0025:  /* 08   |                  */ ldloc.2
    IL_0026:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_002b:  /* 17   |                  */ ldc.i4.1
    IL_002c:  /* 6F   | (0A)000046       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.FieldBuilder/*01000049*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineField(string,
                                                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                              valuetype [mscorlib/*23000001*/]System.Reflection.FieldAttributes/*0100004A*/) /* 0A000046 */
    IL_0031:  /* 0D   |                  */ stloc.3
    IL_0032:  /* 03   |                  */ ldarg.1
    IL_0033:  /* 08   |                  */ ldloc.2
    IL_0034:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_0039:  /* 20   | 00100000         */ ldc.i4     0x1000
    IL_003e:  /* 08   |                  */ ldloc.2
    IL_003f:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_0044:  /* 14   |                  */ ldnull
    IL_0045:  /* 6F   | (0A)000047       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.PropertyBuilder/*0100004B*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineProperty(string,
                                                                                                                                                                                                                                    valuetype [mscorlib/*23000001*/]System.Reflection.PropertyAttributes/*0100004C*/,
                                                                                                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000047 */
    IL_004a:  /* 13   | 04               */ stloc.s    V_4
    IL_004c:  /* 03   |                  */ ldarg.1
    IL_004d:  /* 72   | (70)0001A7       */ ldstr      "get_" /* 700001A7 */
    IL_0052:  /* 08   |                  */ ldloc.2
    IL_0053:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_0058:  /* 28   | (0A)000045       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(string,
                                                                                                                      string) /* 0A000045 */
    IL_005d:  /* 20   | 86080000         */ ldc.i4     0x886
    IL_0062:  /* 08   |                  */ ldloc.2
    IL_0063:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_0068:  /* 7E   | (0A)000048       */ ldsfld     class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::EmptyTypes /* 0A000048 */
    IL_006d:  /* 6F   | (0A)000049       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineMethod(string,
                                                                                                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.MethodAttributes/*0100004E*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000049 */
    IL_0072:  /* 13   | 05               */ stloc.s    V_5
    IL_0074:  /* 11   | 05               */ ldloc.s    V_5
    IL_0076:  /* 6F   | (0A)00004A       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/::GetILGenerator() /* 0A00004A */
    IL_007b:  /* 13   | 06               */ stloc.s    V_6
    IL_007d:  /* 11   | 06               */ ldloc.s    V_6
    IL_007f:  /* 7E   | (0A)00004B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_0 /* 0A00004B */
    IL_0084:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_0089:  /* 11   | 06               */ ldloc.s    V_6
    IL_008b:  /* 7E   | (0A)00004D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldfld /* 0A00004D */
    IL_0090:  /* 09   |                  */ ldloc.3
    IL_0091:  /* 6F   | (0A)00004E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A00004E */
    IL_0096:  /* 11   | 06               */ ldloc.s    V_6
    IL_0098:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_009d:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_00a2:  /* 03   |                  */ ldarg.1
    IL_00a3:  /* 72   | (70)0001B1       */ ldstr      "set_" /* 700001B1 */
    IL_00a8:  /* 08   |                  */ ldloc.2
    IL_00a9:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_00ae:  /* 28   | (0A)000045       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(string,
                                                                                                                      string) /* 0A000045 */
    IL_00b3:  /* 20   | 86080000         */ ldc.i4     0x886
    IL_00b8:  /* 14   |                  */ ldnull
    IL_00b9:  /* 17   |                  */ ldc.i4.1
    IL_00ba:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_00bf:  /* 13   | 09               */ stloc.s    V_9
    IL_00c1:  /* 11   | 09               */ ldloc.s    V_9
    IL_00c3:  /* 16   |                  */ ldc.i4.0
    IL_00c4:  /* 08   |                  */ ldloc.2
    IL_00c5:  /* 6F   | (06)00000F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Type() /* 0600000F */
    IL_00ca:  /* A2   |                  */ stelem.ref
    IL_00cb:  /* 11   | 09               */ ldloc.s    V_9
    IL_00cd:  /* 6F   | (0A)000049       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineMethod(string,
                                                                                                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.MethodAttributes/*0100004E*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000049 */
    IL_00d2:  /* 13   | 07               */ stloc.s    V_7
    IL_00d4:  /* 11   | 07               */ ldloc.s    V_7
    IL_00d6:  /* 6F   | (0A)00004A       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/::GetILGenerator() /* 0A00004A */
    IL_00db:  /* 13   | 08               */ stloc.s    V_8
    IL_00dd:  /* 11   | 08               */ ldloc.s    V_8
    IL_00df:  /* 7E   | (0A)00004B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_0 /* 0A00004B */
    IL_00e4:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_00e9:  /* 11   | 08               */ ldloc.s    V_8
    IL_00eb:  /* 7E   | (0A)000050       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_1 /* 0A000050 */
    IL_00f0:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_00f5:  /* 11   | 08               */ ldloc.s    V_8
    IL_00f7:  /* 7E   | (0A)000051       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Stfld /* 0A000051 */
    IL_00fc:  /* 09   |                  */ ldloc.3
    IL_00fd:  /* 6F   | (0A)00004E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A00004E */
    IL_0102:  /* 11   | 08               */ ldloc.s    V_8
    IL_0104:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_0109:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_010e:  /* 11   | 04               */ ldloc.s    V_4
    IL_0110:  /* 11   | 05               */ ldloc.s    V_5
    IL_0112:  /* 6F   | (0A)000052       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.PropertyBuilder/*0100004B*/::SetGetMethod(class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/) /* 0A000052 */
    IL_0117:  /* 11   | 04               */ ldloc.s    V_4
    IL_0119:  /* 11   | 07               */ ldloc.s    V_7
    IL_011b:  /* 6F   | (0A)000053       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.PropertyBuilder/*0100004B*/::SetSetMethod(class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/) /* 0A000053 */
    IL_0120:  /* 06   |                  */ ldloc.0
    IL_0121:  /* 07   |                  */ ldloc.1
    IL_0122:  /* 09   |                  */ ldloc.3
    IL_0123:  /* A2   |                  */ stelem.ref
    IL_0124:  /* 07   |                  */ ldloc.1
    IL_0125:  /* 17   |                  */ ldc.i4.1
    IL_0126:  /* 58   |                  */ add
    IL_0127:  /* 0B   |                  */ stloc.1
    IL_0128:  /* 07   |                  */ ldloc.1
    IL_0129:  /* 04   |                  */ ldarg.2
    IL_012a:  /* 8E   |                  */ ldlen
    IL_012b:  /* 69   |                  */ conv.i4
    IL_012c:  /* 3F   | DFFEFFFF         */ blt        IL_0010

    IL_0131:  /* 06   |                  */ ldloc.0
    IL_0132:  /* 2A   |                  */ ret
  } // end of method ClassFactory::GenerateProperties

  .method /*06000020*/ private hidebysig 
          instance void  GenerateEquals(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/ tb,
                                        class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] fields) cil managed
  // SIG: 20 02 01 12 4D 1D 12 49
  {
    // Method begins at RVA 0x2a74
    // Code size       428 (0x1ac)
    .maxstack  7
    .locals /*1100000E*/ init (class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ V_0,
             class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ V_1,
             class [mscorlib/*23000001*/]System.Reflection.Emit.LocalBuilder/*01000052*/ V_2,
             valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/ V_3,
             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/ V_4,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_5,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_6,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_7,
             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] V_8,
             int32 V_9,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_10,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_11)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 72   | (70)0001BB       */ ldstr      "Equals" /* 700001BB */
    IL_0006:  /* 20   | C6000000         */ ldc.i4     0xc6
    IL_000b:  /* D0   | (01)000033       */ ldtoken    [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_0010:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0015:  /* 17   |                  */ ldc.i4.1
    IL_0016:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_001b:  /* 13   | 07               */ stloc.s    V_7
    IL_001d:  /* 11   | 07               */ ldloc.s    V_7
    IL_001f:  /* 16   |                  */ ldc.i4.0
    IL_0020:  /* D0   | (01)000001       */ ldtoken    [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0025:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_002a:  /* A2   |                  */ stelem.ref
    IL_002b:  /* 11   | 07               */ ldloc.s    V_7
    IL_002d:  /* 6F   | (0A)000049       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineMethod(string,
                                                                                                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.MethodAttributes/*0100004E*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000049 */
    IL_0032:  /* 0A   |                  */ stloc.0
    IL_0033:  /* 06   |                  */ ldloc.0
    IL_0034:  /* 6F   | (0A)00004A       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/::GetILGenerator() /* 0A00004A */
    IL_0039:  /* 0B   |                  */ stloc.1
    IL_003a:  /* 07   |                  */ ldloc.1
    IL_003b:  /* 03   |                  */ ldarg.1
    IL_003c:  /* 6F   | (0A)000054       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.LocalBuilder/*01000052*/ [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::DeclareLocal(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000054 */
    IL_0041:  /* 0C   |                  */ stloc.2
    IL_0042:  /* 07   |                  */ ldloc.1
    IL_0043:  /* 6F   | (0A)000055       */ callvirt   instance valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/ [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::DefineLabel() /* 0A000055 */
    IL_0048:  /* 0D   |                  */ stloc.3
    IL_0049:  /* 07   |                  */ ldloc.1
    IL_004a:  /* 7E   | (0A)000050       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_1 /* 0A000050 */
    IL_004f:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_0054:  /* 07   |                  */ ldloc.1
    IL_0055:  /* 7E   | (0A)000056       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Isinst /* 0A000056 */
    IL_005a:  /* 03   |                  */ ldarg.1
    IL_005b:  /* 6F   | (0A)000057       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000057 */
    IL_0060:  /* 07   |                  */ ldloc.1
    IL_0061:  /* 7E   | (0A)000058       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Stloc /* 0A000058 */
    IL_0066:  /* 08   |                  */ ldloc.2
    IL_0067:  /* 6F   | (0A)000059       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.Emit.LocalBuilder/*01000052*/) /* 0A000059 */
    IL_006c:  /* 07   |                  */ ldloc.1
    IL_006d:  /* 7E   | (0A)00005A       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldloc /* 0A00005A */
    IL_0072:  /* 08   |                  */ ldloc.2
    IL_0073:  /* 6F   | (0A)000059       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.Emit.LocalBuilder/*01000052*/) /* 0A000059 */
    IL_0078:  /* 07   |                  */ ldloc.1
    IL_0079:  /* 7E   | (0A)00005B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Brtrue_S /* 0A00005B */
    IL_007e:  /* 09   |                  */ ldloc.3
    IL_007f:  /* 6F   | (0A)00005C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/) /* 0A00005C */
    IL_0084:  /* 07   |                  */ ldloc.1
    IL_0085:  /* 7E   | (0A)00005D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldc_I4_0 /* 0A00005D */
    IL_008a:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_008f:  /* 07   |                  */ ldloc.1
    IL_0090:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_0095:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_009a:  /* 07   |                  */ ldloc.1
    IL_009b:  /* 09   |                  */ ldloc.3
    IL_009c:  /* 6F   | (0A)00005E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::MarkLabel(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/) /* 0A00005E */
    IL_00a1:  /* 04   |                  */ ldarg.2
    IL_00a2:  /* 13   | 08               */ stloc.s    V_8
    IL_00a4:  /* 16   |                  */ ldc.i4.0
    IL_00a5:  /* 13   | 09               */ stloc.s    V_9
    IL_00a7:  /* 38   | DE000000         */ br         IL_018a

    IL_00ac:  /* 11   | 08               */ ldloc.s    V_8
    IL_00ae:  /* 11   | 09               */ ldloc.s    V_9
    IL_00b0:  /* 9A   |                  */ ldelem.ref
    IL_00b1:  /* 13   | 04               */ stloc.s    V_4
    IL_00b3:  /* 11   | 04               */ ldloc.s    V_4
    IL_00b5:  /* 6F   | (0A)00005F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/::get_FieldType() /* 0A00005F */
    IL_00ba:  /* 13   | 05               */ stloc.s    V_5
    IL_00bc:  /* D0   | (01)000054       */ ldtoken    [mscorlib/*23000001*/]System.Collections.Generic.EqualityComparer`1/*01000054*/
    IL_00c1:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00c6:  /* 17   |                  */ ldc.i4.1
    IL_00c7:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_00cc:  /* 13   | 0A               */ stloc.s    V_10
    IL_00ce:  /* 11   | 0A               */ ldloc.s    V_10
    IL_00d0:  /* 16   |                  */ ldc.i4.0
    IL_00d1:  /* 11   | 05               */ ldloc.s    V_5
    IL_00d3:  /* A2   |                  */ stelem.ref
    IL_00d4:  /* 11   | 0A               */ ldloc.s    V_10
    IL_00d6:  /* 6F   | (0A)000060       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::MakeGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000060 */
    IL_00db:  /* 13   | 06               */ stloc.s    V_6
    IL_00dd:  /* 07   |                  */ ldloc.1
    IL_00de:  /* 6F   | (0A)000055       */ callvirt   instance valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/ [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::DefineLabel() /* 0A000055 */
    IL_00e3:  /* 0D   |                  */ stloc.3
    IL_00e4:  /* 07   |                  */ ldloc.1
    IL_00e5:  /* 7E   | (0A)000061       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Call /* 0A000061 */
    IL_00ea:  /* 11   | 06               */ ldloc.s    V_6
    IL_00ec:  /* 72   | (70)0001C9       */ ldstr      "get_Default" /* 700001C9 */
    IL_00f1:  /* 6F   | (0A)000062       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string) /* 0A000062 */
    IL_00f6:  /* 14   |                  */ ldnull
    IL_00f7:  /* 6F   | (0A)000063       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::EmitCall(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000063 */
    IL_00fc:  /* 07   |                  */ ldloc.1
    IL_00fd:  /* 7E   | (0A)00004B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_0 /* 0A00004B */
    IL_0102:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_0107:  /* 07   |                  */ ldloc.1
    IL_0108:  /* 7E   | (0A)00004D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldfld /* 0A00004D */
    IL_010d:  /* 11   | 04               */ ldloc.s    V_4
    IL_010f:  /* 6F   | (0A)00004E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A00004E */
    IL_0114:  /* 07   |                  */ ldloc.1
    IL_0115:  /* 7E   | (0A)00005A       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldloc /* 0A00005A */
    IL_011a:  /* 08   |                  */ ldloc.2
    IL_011b:  /* 6F   | (0A)000059       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.Emit.LocalBuilder/*01000052*/) /* 0A000059 */
    IL_0120:  /* 07   |                  */ ldloc.1
    IL_0121:  /* 7E   | (0A)00004D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldfld /* 0A00004D */
    IL_0126:  /* 11   | 04               */ ldloc.s    V_4
    IL_0128:  /* 6F   | (0A)00004E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A00004E */
    IL_012d:  /* 07   |                  */ ldloc.1
    IL_012e:  /* 7E   | (0A)000064       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Callvirt /* 0A000064 */
    IL_0133:  /* 11   | 06               */ ldloc.s    V_6
    IL_0135:  /* 72   | (70)0001BB       */ ldstr      "Equals" /* 700001BB */
    IL_013a:  /* 18   |                  */ ldc.i4.2
    IL_013b:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0140:  /* 13   | 0B               */ stloc.s    V_11
    IL_0142:  /* 11   | 0B               */ ldloc.s    V_11
    IL_0144:  /* 16   |                  */ ldc.i4.0
    IL_0145:  /* 11   | 05               */ ldloc.s    V_5
    IL_0147:  /* A2   |                  */ stelem.ref
    IL_0148:  /* 11   | 0B               */ ldloc.s    V_11
    IL_014a:  /* 17   |                  */ ldc.i4.1
    IL_014b:  /* 11   | 05               */ ldloc.s    V_5
    IL_014d:  /* A2   |                  */ stelem.ref
    IL_014e:  /* 11   | 0B               */ ldloc.s    V_11
    IL_0150:  /* 6F   | (0A)000065       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string,
                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000065 */
    IL_0155:  /* 14   |                  */ ldnull
    IL_0156:  /* 6F   | (0A)000063       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::EmitCall(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000063 */
    IL_015b:  /* 07   |                  */ ldloc.1
    IL_015c:  /* 7E   | (0A)00005B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Brtrue_S /* 0A00005B */
    IL_0161:  /* 09   |                  */ ldloc.3
    IL_0162:  /* 6F   | (0A)00005C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/) /* 0A00005C */
    IL_0167:  /* 07   |                  */ ldloc.1
    IL_0168:  /* 7E   | (0A)00005D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldc_I4_0 /* 0A00005D */
    IL_016d:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_0172:  /* 07   |                  */ ldloc.1
    IL_0173:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_0178:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_017d:  /* 07   |                  */ ldloc.1
    IL_017e:  /* 09   |                  */ ldloc.3
    IL_017f:  /* 6F   | (0A)00005E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::MarkLabel(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.Label/*01000053*/) /* 0A00005E */
    IL_0184:  /* 11   | 09               */ ldloc.s    V_9
    IL_0186:  /* 17   |                  */ ldc.i4.1
    IL_0187:  /* 58   |                  */ add
    IL_0188:  /* 13   | 09               */ stloc.s    V_9
    IL_018a:  /* 11   | 09               */ ldloc.s    V_9
    IL_018c:  /* 11   | 08               */ ldloc.s    V_8
    IL_018e:  /* 8E   |                  */ ldlen
    IL_018f:  /* 69   |                  */ conv.i4
    IL_0190:  /* 3F   | 17FFFFFF         */ blt        IL_00ac

    IL_0195:  /* 07   |                  */ ldloc.1
    IL_0196:  /* 7E   | (0A)000066       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldc_I4_1 /* 0A000066 */
    IL_019b:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_01a0:  /* 07   |                  */ ldloc.1
    IL_01a1:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_01a6:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_01ab:  /* 2A   |                  */ ret
  } // end of method ClassFactory::GenerateEquals

  .method /*06000021*/ private hidebysig 
          instance void  GenerateGetHashCode(class [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/ tb,
                                             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] fields) cil managed
  // SIG: 20 02 01 12 4D 1D 12 49
  {
    // Method begins at RVA 0x2c2c
    // Code size       232 (0xe8)
    .maxstack  7
    .locals /*1100000F*/ init (class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ V_0,
             class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ V_1,
             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/ V_2,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_3,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_4,
             class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/[] V_5,
             int32 V_6,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_7,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_8)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 72   | (70)0001E1       */ ldstr      "GetHashCode" /* 700001E1 */
    IL_0006:  /* 20   | C6000000         */ ldc.i4     0xc6
    IL_000b:  /* D0   | (01)00003C       */ ldtoken    [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0010:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0015:  /* 7E   | (0A)000048       */ ldsfld     class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::EmptyTypes /* 0A000048 */
    IL_001a:  /* 6F   | (0A)000049       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/ [mscorlib/*23000001*/]System.Reflection.Emit.TypeBuilder/*01000013*/::DefineMethod(string,
                                                                                                                                                                                                                                valuetype [mscorlib/*23000001*/]System.Reflection.MethodAttributes/*0100004E*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000049 */
    IL_001f:  /* 0A   |                  */ stloc.0
    IL_0020:  /* 06   |                  */ ldloc.0
    IL_0021:  /* 6F   | (0A)00004A       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/ [mscorlib/*23000001*/]System.Reflection.Emit.MethodBuilder/*0100004D*/::GetILGenerator() /* 0A00004A */
    IL_0026:  /* 0B   |                  */ stloc.1
    IL_0027:  /* 07   |                  */ ldloc.1
    IL_0028:  /* 7E   | (0A)00005D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldc_I4_0 /* 0A00005D */
    IL_002d:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_0032:  /* 04   |                  */ ldarg.2
    IL_0033:  /* 13   | 05               */ stloc.s    V_5
    IL_0035:  /* 16   |                  */ ldc.i4.0
    IL_0036:  /* 13   | 06               */ stloc.s    V_6
    IL_0038:  /* 38   | 94000000         */ br         IL_00d1

    IL_003d:  /* 11   | 05               */ ldloc.s    V_5
    IL_003f:  /* 11   | 06               */ ldloc.s    V_6
    IL_0041:  /* 9A   |                  */ ldelem.ref
    IL_0042:  /* 0C   |                  */ stloc.2
    IL_0043:  /* 08   |                  */ ldloc.2
    IL_0044:  /* 6F   | (0A)00005F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/::get_FieldType() /* 0A00005F */
    IL_0049:  /* 0D   |                  */ stloc.3
    IL_004a:  /* D0   | (01)000054       */ ldtoken    [mscorlib/*23000001*/]System.Collections.Generic.EqualityComparer`1/*01000054*/
    IL_004f:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0054:  /* 17   |                  */ ldc.i4.1
    IL_0055:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_005a:  /* 13   | 07               */ stloc.s    V_7
    IL_005c:  /* 11   | 07               */ ldloc.s    V_7
    IL_005e:  /* 16   |                  */ ldc.i4.0
    IL_005f:  /* 09   |                  */ ldloc.3
    IL_0060:  /* A2   |                  */ stelem.ref
    IL_0061:  /* 11   | 07               */ ldloc.s    V_7
    IL_0063:  /* 6F   | (0A)000060       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::MakeGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000060 */
    IL_0068:  /* 13   | 04               */ stloc.s    V_4
    IL_006a:  /* 07   |                  */ ldloc.1
    IL_006b:  /* 7E   | (0A)000061       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Call /* 0A000061 */
    IL_0070:  /* 11   | 04               */ ldloc.s    V_4
    IL_0072:  /* 72   | (70)0001C9       */ ldstr      "get_Default" /* 700001C9 */
    IL_0077:  /* 6F   | (0A)000062       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string) /* 0A000062 */
    IL_007c:  /* 14   |                  */ ldnull
    IL_007d:  /* 6F   | (0A)000063       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::EmitCall(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000063 */
    IL_0082:  /* 07   |                  */ ldloc.1
    IL_0083:  /* 7E   | (0A)00004B       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldarg_0 /* 0A00004B */
    IL_0088:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_008d:  /* 07   |                  */ ldloc.1
    IL_008e:  /* 7E   | (0A)00004D       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ldfld /* 0A00004D */
    IL_0093:  /* 08   |                  */ ldloc.2
    IL_0094:  /* 6F   | (0A)00004E       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A00004E */
    IL_0099:  /* 07   |                  */ ldloc.1
    IL_009a:  /* 7E   | (0A)000064       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Callvirt /* 0A000064 */
    IL_009f:  /* 11   | 04               */ ldloc.s    V_4
    IL_00a1:  /* 72   | (70)0001E1       */ ldstr      "GetHashCode" /* 700001E1 */
    IL_00a6:  /* 17   |                  */ ldc.i4.1
    IL_00a7:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_00ac:  /* 13   | 08               */ stloc.s    V_8
    IL_00ae:  /* 11   | 08               */ ldloc.s    V_8
    IL_00b0:  /* 16   |                  */ ldc.i4.0
    IL_00b1:  /* 09   |                  */ ldloc.3
    IL_00b2:  /* A2   |                  */ stelem.ref
    IL_00b3:  /* 11   | 08               */ ldloc.s    V_8
    IL_00b5:  /* 6F   | (0A)000065       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string,
                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000065 */
    IL_00ba:  /* 14   |                  */ ldnull
    IL_00bb:  /* 6F   | (0A)000063       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::EmitCall(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                    class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000063 */
    IL_00c0:  /* 07   |                  */ ldloc.1
    IL_00c1:  /* 7E   | (0A)000067       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Xor /* 0A000067 */
    IL_00c6:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_00cb:  /* 11   | 06               */ ldloc.s    V_6
    IL_00cd:  /* 17   |                  */ ldc.i4.1
    IL_00ce:  /* 58   |                  */ add
    IL_00cf:  /* 13   | 06               */ stloc.s    V_6
    IL_00d1:  /* 11   | 06               */ ldloc.s    V_6
    IL_00d3:  /* 11   | 05               */ ldloc.s    V_5
    IL_00d5:  /* 8E   |                  */ ldlen
    IL_00d6:  /* 69   |                  */ conv.i4
    IL_00d7:  /* 3F   | 61FFFFFF         */ blt        IL_003d

    IL_00dc:  /* 07   |                  */ ldloc.1
    IL_00dd:  /* 7E   | (0A)00004F       */ ldsfld     valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/ [mscorlib/*23000001*/]System.Reflection.Emit.OpCodes/*01000050*/::Ret /* 0A00004F */
    IL_00e2:  /* 6F   | (0A)00004C       */ callvirt   instance void [mscorlib/*23000001*/]System.Reflection.Emit.ILGenerator/*0100004F*/::Emit(valuetype [mscorlib/*23000001*/]System.Reflection.Emit.OpCode/*01000051*/) /* 0A00004C */
    IL_00e7:  /* 2A   |                  */ ret
  } // end of method ClassFactory::GenerateGetHashCode

} // end of class System.Linq.Dynamic.ClassFactory

.class /*02000009*/ public auto ansi sealed beforefieldinit System.Linq.Dynamic.ParseException
       extends [mscorlib/*23000001*/]System.Exception/*01000003*/
{
  .field /*0400000C*/ private int32 position
  .method /*06000022*/ public hidebysig specialname rtspecialname 
          instance void  .ctor(string message,
                               int32 position) cil managed
  // SIG: 20 02 01 0E 08
  {
    // Method begins at RVA 0x2d20
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 28   | (0A)000068       */ call       instance void [mscorlib/*23000001*/]System.Exception/*01000003*/::.ctor(string) /* 0A000068 */
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 04   |                  */ ldarg.2
    IL_0009:  /* 7D   | (04)00000C       */ stfld      int32 System.Linq.Dynamic.ParseException/*02000009*/::position /* 0400000C */
    IL_000e:  /* 2A   |                  */ ret
  } // end of method ParseException::.ctor

  .method /*06000023*/ public hidebysig specialname 
          instance int32  get_Position() cil managed
  // SIG: 20 00 08
  {
    // Method begins at RVA 0x2d30
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)00000C       */ ldfld      int32 System.Linq.Dynamic.ParseException/*02000009*/::position /* 0400000C */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method ParseException::get_Position

  .method /*06000024*/ public hidebysig virtual 
          instance string  ToString() cil managed
  // SIG: 20 00 0E
  {
    // Method begins at RVA 0x2d38
    // Code size       28 (0x1c)
    .maxstack  8
    IL_0000:  /* 72   | (70)0001F9       */ ldstr      "{0} (at index {1})" /* 700001F9 */
    IL_0005:  /* 02   |                  */ ldarg.0
    IL_0006:  /* 6F   | (0A)000069       */ callvirt   instance string [mscorlib/*23000001*/]System.Exception/*01000003*/::get_Message() /* 0A000069 */
    IL_000b:  /* 02   |                  */ ldarg.0
    IL_000c:  /* 7B   | (04)00000C       */ ldfld      int32 System.Linq.Dynamic.ParseException/*02000009*/::position /* 0400000C */
    IL_0011:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0016:  /* 28   | (0A)00006A       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Format(string,
                                                                                                                      object,
                                                                                                                      object) /* 0A00006A */
    IL_001b:  /* 2A   |                  */ ret
  } // end of method ParseException::ToString

  .property /*17000003*/ instance int32 Position()
  {
    .get instance int32 System.Linq.Dynamic.ParseException/*02000009*/::get_Position() /* 06000023 */
  } // end of property ParseException::Position
} // end of class System.Linq.Dynamic.ParseException

.class /*0200000A*/ private auto ansi beforefieldinit System.Linq.Dynamic.ExpressionParser
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .class /*0200000B*/ sequential ansi sealed nested private beforefieldinit Token
         extends [mscorlib/*23000001*/]System.ValueType/*01000004*/
  {
    .field /*04000021*/ public valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ id
    .field /*04000022*/ public string text
    .field /*04000023*/ public int32 pos
  } // end of class Token

  .class /*0200000C*/ auto ansi sealed nested private TokenId
         extends [mscorlib/*23000001*/]System.Enum/*01000005*/
  {
    .field /*04000024*/ public specialname rtspecialname int32 value__
    .field /*04000025*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Unknown = int32(0x00000000)
    .field /*04000026*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ End = int32(0x00000001)
    .field /*04000027*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Identifier = int32(0x00000002)
    .field /*04000028*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ StringLiteral = int32(0x00000003)
    .field /*04000029*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ IntegerLiteral = int32(0x00000004)
    .field /*0400002A*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ RealLiteral = int32(0x00000005)
    .field /*0400002B*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Exclamation = int32(0x00000006)
    .field /*0400002C*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Percent = int32(0x00000007)
    .field /*0400002D*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Amphersand = int32(0x00000008)
    .field /*0400002E*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ OpenParen = int32(0x00000009)
    .field /*0400002F*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ CloseParen = int32(0x0000000A)
    .field /*04000030*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Asterisk = int32(0x0000000B)
    .field /*04000031*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Plus = int32(0x0000000C)
    .field /*04000032*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Comma = int32(0x0000000D)
    .field /*04000033*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Minus = int32(0x0000000E)
    .field /*04000034*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Dot = int32(0x0000000F)
    .field /*04000035*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Slash = int32(0x00000010)
    .field /*04000036*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Colon = int32(0x00000011)
    .field /*04000037*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ LessThan = int32(0x00000012)
    .field /*04000038*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Equal = int32(0x00000013)
    .field /*04000039*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ GreaterThan = int32(0x00000014)
    .field /*0400003A*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Question = int32(0x00000015)
    .field /*0400003B*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ OpenBracket = int32(0x00000016)
    .field /*0400003C*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ CloseBracket = int32(0x00000017)
    .field /*0400003D*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ Bar = int32(0x00000018)
    .field /*0400003E*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ ExclamationEqual = int32(0x00000019)
    .field /*0400003F*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ DoubleAmphersand = int32(0x0000001A)
    .field /*04000040*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ LessThanEqual = int32(0x0000001B)
    .field /*04000041*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ LessGreater = int32(0x0000001C)
    .field /*04000042*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ DoubleEqual = int32(0x0000001D)
    .field /*04000043*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ GreaterThanEqual = int32(0x0000001E)
    .field /*04000044*/ public static literal valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ DoubleBar = int32(0x0000001F)
  } // end of class TokenId

  .class /*0200000D*/ interface abstract auto ansi nested private ILogicalSignatures
  {
    .method /*0600007B*/ public hidebysig newslot abstract virtual 
            instance void  F(bool x,
                             bool y) cil managed
    // SIG: 20 02 01 02 02
    {
      // Method begins at RVA 0x0
    } // end of method ILogicalSignatures::F

    .method /*0600007C*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<bool> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<bool> y) cil managed
    // SIG: 20 02 01 15 11 65 01 02 15 11 65 01 02
    {
      // Method begins at RVA 0x0
    } // end of method ILogicalSignatures::F

  } // end of class ILogicalSignatures

  .class /*0200000E*/ interface abstract auto ansi nested private IArithmeticSignatures
  {
    .method /*0600007D*/ public hidebysig newslot abstract virtual 
            instance void  F(int32 x,
                             int32 y) cil managed
    // SIG: 20 02 01 08 08
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*0600007E*/ public hidebysig newslot abstract virtual 
            instance void  F(uint32 x,
                             uint32 y) cil managed
    // SIG: 20 02 01 09 09
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*0600007F*/ public hidebysig newslot abstract virtual 
            instance void  F(int64 x,
                             int64 y) cil managed
    // SIG: 20 02 01 0A 0A
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000080*/ public hidebysig newslot abstract virtual 
            instance void  F(uint64 x,
                             uint64 y) cil managed
    // SIG: 20 02 01 0B 0B
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000081*/ public hidebysig newslot abstract virtual 
            instance void  F(float32 x,
                             float32 y) cil managed
    // SIG: 20 02 01 0C 0C
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000082*/ public hidebysig newslot abstract virtual 
            instance void  F(float64 x,
                             float64 y) cil managed
    // SIG: 20 02 01 0D 0D
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000083*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ x,
                             valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ y) cil managed
    // SIG: 20 02 01 11 69 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000084*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int32> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int32> y) cil managed
    // SIG: 20 02 01 15 11 65 01 08 15 11 65 01 08
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000085*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<uint32> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<uint32> y) cil managed
    // SIG: 20 02 01 15 11 65 01 09 15 11 65 01 09
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000086*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int64> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int64> y) cil managed
    // SIG: 20 02 01 15 11 65 01 0A 15 11 65 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000087*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<uint64> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<uint64> y) cil managed
    // SIG: 20 02 01 15 11 65 01 0B 15 11 65 01 0B
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000088*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float32> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float32> y) cil managed
    // SIG: 20 02 01 15 11 65 01 0C 15 11 65 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*06000089*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float64> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float64> y) cil managed
    // SIG: 20 02 01 15 11 65 01 0D 15 11 65 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

    .method /*0600008A*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 69 15 11 65 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IArithmeticSignatures::F

  } // end of class IArithmeticSignatures

  .class /*0200000F*/ interface abstract auto ansi nested private IRelationalSignatures
         implements System.Linq.Dynamic.ExpressionParser/*0200000A*//IArithmeticSignatures/*0200000E*/
  {
    .method /*0600008B*/ public hidebysig newslot abstract virtual 
            instance void  F(string x,
                             string y) cil managed
    // SIG: 20 02 01 0E 0E
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*0600008C*/ public hidebysig newslot abstract virtual 
            instance void  F(char x,
                             char y) cil managed
    // SIG: 20 02 01 03 03
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*0600008D*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/ x,
                             valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/ y) cil managed
    // SIG: 20 02 01 11 6D 11 6D
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*0600008E*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/ x,
                             valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/ y) cil managed
    // SIG: 20 02 01 11 71 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*0600008F*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<char> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<char> y) cil managed
    // SIG: 20 02 01 15 11 65 01 03 15 11 65 01 03
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*06000090*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 6D 15 11 65 01 11 6D
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

    .method /*06000091*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 71 15 11 65 01 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IRelationalSignatures::F

  } // end of class IRelationalSignatures

  .class /*02000010*/ interface abstract auto ansi nested private IEqualitySignatures
         implements System.Linq.Dynamic.ExpressionParser/*0200000A*//IRelationalSignatures/*0200000F*/,
                    System.Linq.Dynamic.ExpressionParser/*0200000A*//IArithmeticSignatures/*0200000E*/
  {
    .method /*06000092*/ public hidebysig newslot abstract virtual 
            instance void  F(bool x,
                             bool y) cil managed
    // SIG: 20 02 01 02 02
    {
      // Method begins at RVA 0x0
    } // end of method IEqualitySignatures::F

    .method /*06000093*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<bool> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<bool> y) cil managed
    // SIG: 20 02 01 15 11 65 01 02 15 11 65 01 02
    {
      // Method begins at RVA 0x0
    } // end of method IEqualitySignatures::F

  } // end of class IEqualitySignatures

  .class /*02000011*/ interface abstract auto ansi nested private IAddSignatures
         implements System.Linq.Dynamic.ExpressionParser/*0200000A*//IArithmeticSignatures/*0200000E*/
  {
    .method /*06000094*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/ x,
                             valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/ y) cil managed
    // SIG: 20 02 01 11 6D 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IAddSignatures::F

    .method /*06000095*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/ x,
                             valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/ y) cil managed
    // SIG: 20 02 01 11 71 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IAddSignatures::F

    .method /*06000096*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 6D 15 11 65 01 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IAddSignatures::F

    .method /*06000097*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 71 15 11 65 01 11 71
    {
      // Method begins at RVA 0x0
    } // end of method IAddSignatures::F

  } // end of class IAddSignatures

  .class /*02000012*/ interface abstract auto ansi nested private ISubtractSignatures
         implements System.Linq.Dynamic.ExpressionParser/*0200000A*//IAddSignatures/*02000011*/,
                    System.Linq.Dynamic.ExpressionParser/*0200000A*//IArithmeticSignatures/*0200000E*/
  {
    .method /*06000098*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/ x,
                             valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/ y) cil managed
    // SIG: 20 02 01 11 6D 11 6D
    {
      // Method begins at RVA 0x0
    } // end of method ISubtractSignatures::F

    .method /*06000099*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/> x,
                             valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.DateTime/*0100001B*/> y) cil managed
    // SIG: 20 02 01 15 11 65 01 11 6D 15 11 65 01 11 6D
    {
      // Method begins at RVA 0x0
    } // end of method ISubtractSignatures::F

  } // end of class ISubtractSignatures

  .class /*02000013*/ interface abstract auto ansi nested private INegationSignatures
  {
    .method /*0600009A*/ public hidebysig newslot abstract virtual 
            instance void  F(int32 x) cil managed
    // SIG: 20 01 01 08
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*0600009B*/ public hidebysig newslot abstract virtual 
            instance void  F(int64 x) cil managed
    // SIG: 20 01 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*0600009C*/ public hidebysig newslot abstract virtual 
            instance void  F(float32 x) cil managed
    // SIG: 20 01 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*0600009D*/ public hidebysig newslot abstract virtual 
            instance void  F(float64 x) cil managed
    // SIG: 20 01 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*0600009E*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ x) cil managed
    // SIG: 20 01 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*0600009F*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int32> x) cil managed
    // SIG: 20 01 01 15 11 65 01 08
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*060000A0*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int64> x) cil managed
    // SIG: 20 01 01 15 11 65 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*060000A1*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float32> x) cil managed
    // SIG: 20 01 01 15 11 65 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*060000A2*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float64> x) cil managed
    // SIG: 20 01 01 15 11 65 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

    .method /*060000A3*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/> x) cil managed
    // SIG: 20 01 01 15 11 65 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method INegationSignatures::F

  } // end of class INegationSignatures

  .class /*02000014*/ interface abstract auto ansi nested private INotSignatures
  {
    .method /*060000A4*/ public hidebysig newslot abstract virtual 
            instance void  F(bool x) cil managed
    // SIG: 20 01 01 02
    {
      // Method begins at RVA 0x0
    } // end of method INotSignatures::F

    .method /*060000A5*/ public hidebysig newslot abstract virtual 
            instance void  F(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<bool> x) cil managed
    // SIG: 20 01 01 15 11 65 01 02
    {
      // Method begins at RVA 0x0
    } // end of method INotSignatures::F

  } // end of class INotSignatures

  .class /*02000015*/ interface abstract auto ansi nested private IEnumerableSignatures
  {
    .method /*060000A6*/ public hidebysig newslot abstract virtual 
            instance void  Where(bool predicate) cil managed
    // SIG: 20 01 01 02
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Where

    .method /*060000A7*/ public hidebysig newslot abstract virtual 
            instance void  Any() cil managed
    // SIG: 20 00 01
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Any

    .method /*060000A8*/ public hidebysig newslot abstract virtual 
            instance void  Any(bool predicate) cil managed
    // SIG: 20 01 01 02
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Any

    .method /*060000A9*/ public hidebysig newslot abstract virtual 
            instance void  All(bool predicate) cil managed
    // SIG: 20 01 01 02
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::All

    .method /*060000AA*/ public hidebysig newslot abstract virtual 
            instance void  Count() cil managed
    // SIG: 20 00 01
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Count

    .method /*060000AB*/ public hidebysig newslot abstract virtual 
            instance void  Count(bool predicate) cil managed
    // SIG: 20 01 01 02
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Count

    .method /*060000AC*/ public hidebysig newslot abstract virtual 
            instance void  Min(object selector) cil managed
    // SIG: 20 01 01 1C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Min

    .method /*060000AD*/ public hidebysig newslot abstract virtual 
            instance void  Max(object selector) cil managed
    // SIG: 20 01 01 1C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Max

    .method /*060000AE*/ public hidebysig newslot abstract virtual 
            instance void  Sum(int32 selector) cil managed
    // SIG: 20 01 01 08
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000AF*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int32> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 08
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B0*/ public hidebysig newslot abstract virtual 
            instance void  Sum(int64 selector) cil managed
    // SIG: 20 01 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B1*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int64> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B2*/ public hidebysig newslot abstract virtual 
            instance void  Sum(float32 selector) cil managed
    // SIG: 20 01 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B3*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float32> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B4*/ public hidebysig newslot abstract virtual 
            instance void  Sum(float64 selector) cil managed
    // SIG: 20 01 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B5*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float64> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B6*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ selector) cil managed
    // SIG: 20 01 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B7*/ public hidebysig newslot abstract virtual 
            instance void  Sum(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Sum

    .method /*060000B8*/ public hidebysig newslot abstract virtual 
            instance void  Average(int32 selector) cil managed
    // SIG: 20 01 01 08
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000B9*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int32> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 08
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BA*/ public hidebysig newslot abstract virtual 
            instance void  Average(int64 selector) cil managed
    // SIG: 20 01 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BB*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<int64> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0A
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BC*/ public hidebysig newslot abstract virtual 
            instance void  Average(float32 selector) cil managed
    // SIG: 20 01 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BD*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float32> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0C
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BE*/ public hidebysig newslot abstract virtual 
            instance void  Average(float64 selector) cil managed
    // SIG: 20 01 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000BF*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<float64> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 0D
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000C0*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ selector) cil managed
    // SIG: 20 01 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

    .method /*060000C1*/ public hidebysig newslot abstract virtual 
            instance void  Average(valuetype [mscorlib/*23000001*/]System.Nullable`1/*01000019*/<valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/> selector) cil managed
    // SIG: 20 01 01 15 11 65 01 11 69
    {
      // Method begins at RVA 0x0
    } // end of method IEnumerableSignatures::Average

  } // end of class IEnumerableSignatures

  .class /*02000016*/ auto ansi nested private beforefieldinit MethodData
         extends [mscorlib/*23000001*/]System.Object/*01000001*/
  {
    .field /*04000045*/ public class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ MethodBase
    .field /*04000046*/ public class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] Parameters
    .field /*04000047*/ public class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] Args
    .method /*060000C2*/ public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    // SIG: 20 00 01
    {
      // Method begins at RVA 0x5cff
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
      IL_0006:  /* 2A   |                  */ ret
    } // end of method MethodData::.ctor

  } // end of class MethodData

  .class /*02000018*/ auto ansi sealed nested private beforefieldinit '<SelfAndBaseClasses>d__5'
         extends [mscorlib/*23000001*/]System.Object/*01000001*/
         implements class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000011*/,
                    [mscorlib/*23000001*/]System.Collections.IEnumerable/*0100006C*/,
                    class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000012*/,
                    [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/,
                    [mscorlib/*23000001*/]System.IDisposable/*0100003B*/
  {
    .custom /*0C000021:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
    .field /*04000074*/ private class [mscorlib/*23000001*/]System.Type/*01000008*/ '<>2__current'
    .field /*04000075*/ private int32 '<>1__state'
    .field /*04000076*/ private int32 '<>l__initialThreadId'
    .field /*04000077*/ public class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type'
    .field /*04000078*/ public class [mscorlib/*23000001*/]System.Type/*01000008*/ '<>3__type'
    .method /*060000C3*/ private hidebysig newslot virtual final 
            instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> 
            'System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator'() cil managed
    // SIG: 20 00 15 12 80 E5 01 12 21
    {
      .custom /*0C000030:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      .override  method instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000011*/::GetEnumerator() /* 0A0000B0 */
      // Method begins at RVA 0x4a20
      // Code size       60 (0x3c)
      .maxstack  2
      .locals /*11000036*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/ V_0)
      IL_0000:  /* 28   | (0A)0000C3       */ call       class [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/ [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/::get_CurrentThread() /* 0A0000C3 */
      IL_0005:  /* 6F   | (0A)0000C4       */ callvirt   instance int32 [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/::get_ManagedThreadId() /* 0A0000C4 */
      IL_000a:  /* 02   |                  */ ldarg.0
      IL_000b:  /* 7B   | (04)000076       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>l__initialThreadId' /* 04000076 */
      IL_0010:  /* 33   | 15               */ bne.un.s   IL_0027

      IL_0012:  /* 02   |                  */ ldarg.0
      IL_0013:  /* 7B   | (04)000075       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_0018:  /* 1F   | FE               */ ldc.i4.s   -2
      IL_001a:  /* 33   | 0B               */ bne.un.s   IL_0027

      IL_001c:  /* 02   |                  */ ldarg.0
      IL_001d:  /* 16   |                  */ ldc.i4.0
      IL_001e:  /* 7D   | (04)000075       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_0023:  /* 02   |                  */ ldarg.0
      IL_0024:  /* 0A   |                  */ stloc.0
      IL_0025:  /* 2B   | 07               */ br.s       IL_002e

      IL_0027:  /* 16   |                  */ ldc.i4.0
      IL_0028:  /* 73   | (06)0000CA       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::.ctor(int32) /* 060000CA */
      IL_002d:  /* 0A   |                  */ stloc.0
      IL_002e:  /* 06   |                  */ ldloc.0
      IL_002f:  /* 02   |                  */ ldarg.0
      IL_0030:  /* 7B   | (04)000078       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>3__type' /* 04000078 */
      IL_0035:  /* 7D   | (04)000077       */ stfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'type' /* 04000077 */
      IL_003a:  /* 06   |                  */ ldloc.0
      IL_003b:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::'System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator'

    .method /*060000C4*/ private hidebysig newslot virtual final 
            instance class [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/ 
            System.Collections.IEnumerable.GetEnumerator() cil managed
    // SIG: 20 00 12 80 E9
    {
      .custom /*0C000031:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      .override [mscorlib/*23000001*/]System.Collections.IEnumerable/*0100006C*/::GetEnumerator /*0100006C::0A0000BF*/ 
      // Method begins at RVA 0x4a68
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 28   | (06)0000C3       */ call       instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator'() /* 060000C3 */
      IL_0006:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::System.Collections.IEnumerable.GetEnumerator

    .method /*060000C5*/ private hidebysig newslot virtual final 
            instance bool  MoveNext() cil managed
    // SIG: 20 00 02
    {
      .override [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext /*0100003A::0A000022*/ 
      // Method begins at RVA 0x4a70
      // Code size       93 (0x5d)
      .maxstack  2
      .locals /*11000009*/ init (int32 V_0)
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 7B   | (04)000075       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_0006:  /* 0A   |                  */ stloc.0
      IL_0007:  /* 06   |                  */ ldloc.0
      IL_0008:  /* 45   | 02000000         */ switch     ( 
                /*      | 02000000         */             IL_0017,
                /*      | 20000000         */             IL_0035)
      IL_0015:  /* 2B   | 44               */ br.s       IL_005b

      IL_0017:  /* 02   |                  */ ldarg.0
      IL_0018:  /* 15   |                  */ ldc.i4.m1
      IL_0019:  /* 7D   | (04)000075       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_001e:  /* 2B   | 2D               */ br.s       IL_004d

      IL_0020:  /* 02   |                  */ ldarg.0
      IL_0021:  /* 02   |                  */ ldarg.0
      IL_0022:  /* 7B   | (04)000077       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'type' /* 04000077 */
      IL_0027:  /* 7D   | (04)000074       */ stfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>2__current' /* 04000074 */
      IL_002c:  /* 02   |                  */ ldarg.0
      IL_002d:  /* 17   |                  */ ldc.i4.1
      IL_002e:  /* 7D   | (04)000075       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_0033:  /* 17   |                  */ ldc.i4.1
      IL_0034:  /* 2A   |                  */ ret

      IL_0035:  /* 02   |                  */ ldarg.0
      IL_0036:  /* 15   |                  */ ldc.i4.m1
      IL_0037:  /* 7D   | (04)000075       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_003c:  /* 02   |                  */ ldarg.0
      IL_003d:  /* 02   |                  */ ldarg.0
      IL_003e:  /* 7B   | (04)000077       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'type' /* 04000077 */
      IL_0043:  /* 6F   | (0A)0000A8       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::get_BaseType() /* 0A0000A8 */
      IL_0048:  /* 7D   | (04)000077       */ stfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'type' /* 04000077 */
      IL_004d:  /* 02   |                  */ ldarg.0
      IL_004e:  /* 7B   | (04)000077       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'type' /* 04000077 */
      IL_0053:  /* 14   |                  */ ldnull
      IL_0054:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
      IL_0059:  /* 2D   | C5               */ brtrue.s   IL_0020

      IL_005b:  /* 16   |                  */ ldc.i4.0
      IL_005c:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::MoveNext

    .method /*060000C6*/ private hidebysig newslot specialname virtual final 
            instance class [mscorlib/*23000001*/]System.Type/*01000008*/ 
            'System.Collections.Generic.IEnumerator<System.Type>.get_Current'() cil managed
    // SIG: 20 00 12 21
    {
      .custom /*0C000032:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      .override  method instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000012*/::get_Current() /* 0A0000B1 */
      // Method begins at RVA 0x4ad9
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 7B   | (04)000074       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>2__current' /* 04000074 */
      IL_0006:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::'System.Collections.Generic.IEnumerator<System.Type>.get_Current'

    .method /*060000C7*/ private hidebysig newslot virtual final 
            instance void  System.Collections.IEnumerator.Reset() cil managed
    // SIG: 20 00 01
    {
      .custom /*0C000033:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      .override [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::Reset /*0100003A::0A0000C0*/ 
      // Method begins at RVA 0x4ae1
      // Code size       6 (0x6)
      .maxstack  8
      IL_0000:  /* 73   | (0A)0000C5       */ newobj     instance void [mscorlib/*23000001*/]System.NotSupportedException/*01000070*/::.ctor() /* 0A0000C5 */
      IL_0005:  /* 7A   |                  */ throw
    } // end of method '<SelfAndBaseClasses>d__5'::System.Collections.IEnumerator.Reset

    .method /*060000C8*/ private hidebysig newslot virtual final 
            instance void  System.IDisposable.Dispose() cil managed
    // SIG: 20 00 01
    {
      .override [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose /*0100003B::0A000023*/ 
      // Method begins at RVA 0x4ae8
      // Code size       1 (0x1)
      .maxstack  8
      IL_0000:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::System.IDisposable.Dispose

    .method /*060000C9*/ private hidebysig newslot specialname virtual final 
            instance object  System.Collections.IEnumerator.get_Current() cil managed
    // SIG: 20 00 1C
    {
      .custom /*0C000034:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      .override [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::get_Current /*0100003A::0A0000C1*/ 
      // Method begins at RVA 0x4aea
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 7B   | (04)000074       */ ldfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>2__current' /* 04000074 */
      IL_0006:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::System.Collections.IEnumerator.get_Current

    .method /*060000CA*/ public hidebysig specialname rtspecialname 
            instance void  .ctor(int32 '<>1__state') cil managed
    // SIG: 20 01 01 08
    {
      .custom /*0C000035:0A0000C2*/ instance void [mscorlib/*23000001*/]System.Diagnostics.DebuggerHiddenAttribute/*0100006E*/::.ctor() /* 0A0000C2 */ = ( 01 00 00 00 ) 
      // Method begins at RVA 0x4af2
      // Code size       30 (0x1e)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
      IL_0006:  /* 02   |                  */ ldarg.0
      IL_0007:  /* 03   |                  */ ldarg.1
      IL_0008:  /* 7D   | (04)000075       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>1__state' /* 04000075 */
      IL_000d:  /* 02   |                  */ ldarg.0
      IL_000e:  /* 28   | (0A)0000C3       */ call       class [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/ [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/::get_CurrentThread() /* 0A0000C3 */
      IL_0013:  /* 6F   | (0A)0000C4       */ callvirt   instance int32 [mscorlib/*23000001*/]System.Threading.Thread/*0100006F*/::get_ManagedThreadId() /* 0A0000C4 */
      IL_0018:  /* 7D   | (04)000076       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>l__initialThreadId' /* 04000076 */
      IL_001d:  /* 2A   |                  */ ret
    } // end of method '<SelfAndBaseClasses>d__5'::.ctor

    .property /*17000004*/ instance class [mscorlib/*23000001*/]System.Type/*01000008*/
            'System.Collections.Generic.IEnumerator<System.Type>.Current'()
    {
      .get instance class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'System.Collections.Generic.IEnumerator<System.Type>.get_Current'() /* 060000C6 */
    } // end of property '<SelfAndBaseClasses>d__5'::'System.Collections.Generic.IEnumerator<System.Type>.Current'
    .property /*17000005*/ instance object
            System.Collections.IEnumerator.Current()
    {
      .get instance object System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::System.Collections.IEnumerator.get_Current() /* 060000C9 */
    } // end of property '<SelfAndBaseClasses>d__5'::System.Collections.IEnumerator.Current
  } // end of class '<SelfAndBaseClasses>d__5'

  .class /*02000019*/ auto ansi sealed nested private beforefieldinit '<>c__DisplayClassf'
         extends [mscorlib/*23000001*/]System.Object/*01000001*/
  {
    .custom /*0C000022:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
    .class /*0200001A*/ auto ansi sealed nested private beforefieldinit '<>c__DisplayClass11'
           extends [mscorlib/*23000001*/]System.Object/*01000001*/
    {
      .field /*0400007C*/ public class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/ 'CS$<>8__locals10'
      .field /*0400007D*/ public class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ m
      .method /*060000CE*/ public hidebysig specialname rtspecialname 
              instance void  .ctor() cil managed
      // SIG: 20 00 01
      {
        // Method begins at RVA 0x4bb7
        // Code size       7 (0x7)
        .maxstack  8
        IL_0000:  /* 02   |                  */ ldarg.0
        IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
        IL_0006:  /* 2A   |                  */ ret
      } // end of method '<>c__DisplayClass11'::.ctor

      .method /*060000CF*/ public hidebysig 
              instance bool  '<FindBestMethod>b__c'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ n) cil managed
      // SIG: 20 01 02 12 58
      {
        // Method begins at RVA 0x4bbf
        // Code size       35 (0x23)
        .maxstack  8
        IL_0000:  /* 02   |                  */ ldarg.0
        IL_0001:  /* 7B   | (04)00007D       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::m /* 0400007D */
        IL_0006:  /* 03   |                  */ ldarg.1
        IL_0007:  /* 2E   | 18               */ beq.s      IL_0021

        IL_0009:  /* 02   |                  */ ldarg.0
        IL_000a:  /* 7B   | (04)00007C       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::'CS$<>8__locals10' /* 0400007C */
        IL_000f:  /* 7B   | (04)00007B       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::args /* 0400007B */
        IL_0014:  /* 02   |                  */ ldarg.0
        IL_0015:  /* 7B   | (04)00007D       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::m /* 0400007D */
        IL_001a:  /* 03   |                  */ ldarg.1
        IL_001b:  /* 28   | (06)00005F       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsBetterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                               class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,
                                                                                                                               class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/) /* 0600005F */
        IL_0020:  /* 2A   |                  */ ret

        IL_0021:  /* 17   |                  */ ldc.i4.1
        IL_0022:  /* 2A   |                  */ ret
      } // end of method '<>c__DisplayClass11'::'<FindBestMethod>b__c'

    } // end of class '<>c__DisplayClass11'

    .field /*04000079*/ public class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] applicable
    .field /*0400007A*/ public class System.Linq.Dynamic.ExpressionParser/*0200000A*/ '<>4__this'
    .field /*0400007B*/ public class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args
    .method /*060000CB*/ public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    // SIG: 20 00 01
    {
      // Method begins at RVA 0x4b71
      // Code size       7 (0x7)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
      IL_0006:  /* 2A   |                  */ ret
    } // end of method '<>c__DisplayClassf'::.ctor

    .method /*060000CC*/ public hidebysig 
            instance bool  '<FindBestMethod>b__a'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ m) cil managed
    // SIG: 20 01 02 12 58
    {
      // Method begins at RVA 0x4ba3
      // Code size       19 (0x13)
      .maxstack  8
      IL_0000:  /* 02   |                  */ ldarg.0
      IL_0001:  /* 7B   | (04)00007A       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::'<>4__this' /* 0400007A */
      IL_0006:  /* 03   |                  */ ldarg.1
      IL_0007:  /* 02   |                  */ ldarg.0
      IL_0008:  /* 7B   | (04)00007B       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::args /* 0400007B */
      IL_000d:  /* 28   | (06)00005A       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsApplicable(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,
                                                                                                                                      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0600005A */
      IL_0012:  /* 2A   |                  */ ret
    } // end of method '<>c__DisplayClassf'::'<FindBestMethod>b__a'

    .method /*060000CD*/ public hidebysig 
            instance bool  '<FindBestMethod>b__b'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ m) cil managed
    // SIG: 20 01 02 12 58
    {
      // Method begins at RVA 0x4be4
      // Code size       44 (0x2c)
      .maxstack  4
      .locals /*11000039*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/ V_0)
      IL_0000:  /* 73   | (06)0000CE       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::.ctor() /* 060000CE */
      IL_0005:  /* 0A   |                  */ stloc.0
      IL_0006:  /* 06   |                  */ ldloc.0
      IL_0007:  /* 02   |                  */ ldarg.0
      IL_0008:  /* 7D   | (04)00007C       */ stfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::'CS$<>8__locals10' /* 0400007C */
      IL_000d:  /* 06   |                  */ ldloc.0
      IL_000e:  /* 03   |                  */ ldarg.1
      IL_000f:  /* 7D   | (04)00007D       */ stfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::m /* 0400007D */
      IL_0014:  /* 02   |                  */ ldarg.0
      IL_0015:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
      IL_001a:  /* 06   |                  */ ldloc.0
      IL_001b:  /* FE06 | (06)0000CF       */ ldftn      instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*//'<>c__DisplayClass11'/*0200001A*/::'<FindBestMethod>b__c'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/) /* 060000CF */
      IL_0021:  /* 73   | (0A)0000C9       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,bool>/*1B000016*/::.ctor(object,
                                                                                                                                                                                                                                    native int) /* 0A0000C9 */
      IL_0026:  /* 28   | (2B)000006       */ call       bool [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::All<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,bool>) /* 2B000006 */
      IL_002b:  /* 2A   |                  */ ret
    } // end of method '<>c__DisplayClassf'::'<FindBestMethod>b__b'

  } // end of class '<>c__DisplayClassf'

  .field /*0400000D*/ private static initonly class [mscorlib/*23000001*/]System.Type/*01000008*/[] predefinedTypes
  .field /*0400000E*/ private static initonly class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ trueLiteral
  .field /*0400000F*/ private static initonly class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ falseLiteral
  .field /*04000010*/ private static initonly class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ nullLiteral
  .field /*04000011*/ private static initonly string keywordIt
  .field /*04000012*/ private static initonly string keywordIif
  .field /*04000013*/ private static initonly string keywordNew
  .field /*04000014*/ private static class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> keywords
  .field /*04000015*/ private class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> symbols
  .field /*04000016*/ private class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object> externals
  .field /*04000017*/ private class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string> literals
  .field /*04000018*/ private class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ it
  .field /*04000019*/ private string text
  .field /*0400001A*/ private int32 textPos
  .field /*0400001B*/ private int32 textLen
  .field /*0400001C*/ private char ch
  .field /*0400001D*/ private valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ token
  .field /*0400001E*/ private static class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> 'CS$<>9__CachedAnonymousMethodDelegate3'
  .custom /*0C000023:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
  .field /*0400001F*/ private static class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,bool> 'CS$<>9__CachedAnonymousMethodDelegate4'
  .custom /*0C000025:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
  .field /*04000020*/ private static class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/> 'CS$<>9__CachedAnonymousMethodDelegated'
  .custom /*0C000026:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
  .method /*06000025*/ public hidebysig specialname rtspecialname 
          instance void  .ctor(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] parameters,
                               string expression,
                               object[] values) cil managed
  // SIG: 20 03 01 1D 12 2D 0E 1D 1C
  {
    // Method begins at RVA 0x2d58
    // Code size       122 (0x7a)
    .maxstack  3
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (0A)00002E       */ call       instance void [mscorlib/*23000001*/]System.Object/*01000001*/::.ctor() /* 0A00002E */
    IL_0006:  /* 04   |                  */ ldarg.2
    IL_0007:  /* 2D   | 0B               */ brtrue.s   IL_0014

    IL_0009:  /* 72   | (70)00021F       */ ldstr      "expression" /* 7000021F */
    IL_000e:  /* 73   | (0A)000014       */ newobj     instance void [mscorlib/*23000001*/]System.ArgumentNullException/*01000032*/::.ctor(string) /* 0A000014 */
    IL_0013:  /* 7A   |                  */ throw

    IL_0014:  /* 7E   | (04)000014       */ ldsfld     class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywords /* 04000014 */
    IL_0019:  /* 2D   | 0A               */ brtrue.s   IL_0025

    IL_001b:  /* 28   | (06)000076       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateKeywords() /* 06000076 */
    IL_0020:  /* 80   | (04)000014       */ stsfld     class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywords /* 04000014 */
    IL_0025:  /* 02   |                  */ ldarg.0
    IL_0026:  /* 28   | (0A)00006B       */ call       class [mscorlib/*23000001*/]System.StringComparer/*01000055*/ [mscorlib/*23000001*/]System.StringComparer/*01000055*/::get_OrdinalIgnoreCase() /* 0A00006B */
    IL_002b:  /* 73   | (0A)00006C       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::.ctor(class [mscorlib/*23000001*/]System.Collections.Generic.IEqualityComparer`1/*01000056*/<!0>) /* 0A00006C */
    IL_0030:  /* 7D   | (04)000015       */ stfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::symbols /* 04000015 */
    IL_0035:  /* 02   |                  */ ldarg.0
    IL_0036:  /* 73   | (0A)00006D       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string>/*1B00000C*/::.ctor() /* 0A00006D */
    IL_003b:  /* 7D   | (04)000017       */ stfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string> System.Linq.Dynamic.ExpressionParser/*0200000A*/::literals /* 04000017 */
    IL_0040:  /* 03   |                  */ ldarg.1
    IL_0041:  /* 2C   | 07               */ brfalse.s  IL_004a

    IL_0043:  /* 02   |                  */ ldarg.0
    IL_0044:  /* 03   |                  */ ldarg.1
    IL_0045:  /* 28   | (06)000026       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ProcessParameters(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[]) /* 06000026 */
    IL_004a:  /* 05   |                  */ ldarg.3
    IL_004b:  /* 2C   | 07               */ brfalse.s  IL_0054

    IL_004d:  /* 02   |                  */ ldarg.0
    IL_004e:  /* 05   |                  */ ldarg.3
    IL_004f:  /* 28   | (06)000027       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ProcessValues(object[]) /* 06000027 */
    IL_0054:  /* 02   |                  */ ldarg.0
    IL_0055:  /* 04   |                  */ ldarg.2
    IL_0056:  /* 7D   | (04)000019       */ stfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*/::text /* 04000019 */
    IL_005b:  /* 02   |                  */ ldarg.0
    IL_005c:  /* 02   |                  */ ldarg.0
    IL_005d:  /* 7B   | (04)000019       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*/::text /* 04000019 */
    IL_0062:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_0067:  /* 7D   | (04)00001B       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_006c:  /* 02   |                  */ ldarg.0
    IL_006d:  /* 16   |                  */ ldc.i4.0
    IL_006e:  /* 28   | (06)00006C       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::SetTextPos(int32) /* 0600006C */
    IL_0073:  /* 02   |                  */ ldarg.0
    IL_0074:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0079:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::.ctor

  .method /*06000026*/ private hidebysig 
          instance void  ProcessParameters(class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] parameters) cil managed
  // SIG: 20 01 01 1D 12 2D
  {
    // Method begins at RVA 0x2de0
    // Code size       77 (0x4d)
    .maxstack  3
    .locals /*11000010*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] V_1,
             int32 V_2)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 0B   |                  */ stloc.1
    IL_0002:  /* 16   |                  */ ldc.i4.0
    IL_0003:  /* 0C   |                  */ stloc.2
    IL_0004:  /* 2B   | 22               */ br.s       IL_0028

    IL_0006:  /* 07   |                  */ ldloc.1
    IL_0007:  /* 08   |                  */ ldloc.2
    IL_0008:  /* 9A   |                  */ ldelem.ref
    IL_0009:  /* 0A   |                  */ stloc.0
    IL_000a:  /* 06   |                  */ ldloc.0
    IL_000b:  /* 6F   | (0A)00006F       */ callvirt   instance string [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/::get_Name() /* 0A00006F */
    IL_0010:  /* 28   | (0A)000070       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::IsNullOrEmpty(string) /* 0A000070 */
    IL_0015:  /* 2D   | 0D               */ brtrue.s   IL_0024

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 06   |                  */ ldloc.0
    IL_0019:  /* 6F   | (0A)00006F       */ callvirt   instance string [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/::get_Name() /* 0A00006F */
    IL_001e:  /* 06   |                  */ ldloc.0
    IL_001f:  /* 28   | (06)000028       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::AddSymbol(string,
                                                                                                                                 object) /* 06000028 */
    IL_0024:  /* 08   |                  */ ldloc.2
    IL_0025:  /* 17   |                  */ ldc.i4.1
    IL_0026:  /* 58   |                  */ add
    IL_0027:  /* 0C   |                  */ stloc.2
    IL_0028:  /* 08   |                  */ ldloc.2
    IL_0029:  /* 07   |                  */ ldloc.1
    IL_002a:  /* 8E   |                  */ ldlen
    IL_002b:  /* 69   |                  */ conv.i4
    IL_002c:  /* 32   | D8               */ blt.s      IL_0006

    IL_002e:  /* 03   |                  */ ldarg.1
    IL_002f:  /* 8E   |                  */ ldlen
    IL_0030:  /* 69   |                  */ conv.i4
    IL_0031:  /* 17   |                  */ ldc.i4.1
    IL_0032:  /* 33   | 18               */ bne.un.s   IL_004c

    IL_0034:  /* 03   |                  */ ldarg.1
    IL_0035:  /* 16   |                  */ ldc.i4.0
    IL_0036:  /* 9A   |                  */ ldelem.ref
    IL_0037:  /* 6F   | (0A)00006F       */ callvirt   instance string [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/::get_Name() /* 0A00006F */
    IL_003c:  /* 28   | (0A)000070       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::IsNullOrEmpty(string) /* 0A000070 */
    IL_0041:  /* 2C   | 09               */ brfalse.s  IL_004c

    IL_0043:  /* 02   |                  */ ldarg.0
    IL_0044:  /* 03   |                  */ ldarg.1
    IL_0045:  /* 16   |                  */ ldc.i4.0
    IL_0046:  /* 9A   |                  */ ldelem.ref
    IL_0047:  /* 7D   | (04)000018       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_004c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ProcessParameters

  .method /*06000027*/ private hidebysig 
          instance void  ProcessValues(object[] values) cil managed
  // SIG: 20 01 01 1D 1C
  {
    // Method begins at RVA 0x2e3c
    // Code size       78 (0x4e)
    .maxstack  4
    .locals /*11000011*/ init (int32 V_0,
             object V_1)
    IL_0000:  /* 16   |                  */ ldc.i4.0
    IL_0001:  /* 0A   |                  */ stloc.0
    IL_0002:  /* 2B   | 43               */ br.s       IL_0047

    IL_0004:  /* 03   |                  */ ldarg.1
    IL_0005:  /* 06   |                  */ ldloc.0
    IL_0006:  /* 9A   |                  */ ldelem.ref
    IL_0007:  /* 0B   |                  */ stloc.1
    IL_0008:  /* 06   |                  */ ldloc.0
    IL_0009:  /* 03   |                  */ ldarg.1
    IL_000a:  /* 8E   |                  */ ldlen
    IL_000b:  /* 69   |                  */ conv.i4
    IL_000c:  /* 17   |                  */ ldc.i4.1
    IL_000d:  /* 59   |                  */ sub
    IL_000e:  /* 33   | 16               */ bne.un.s   IL_0026

    IL_0010:  /* 07   |                  */ ldloc.1
    IL_0011:  /* 75   | (1B)00000D       */ isinst     class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object>/*1B00000D*/
    IL_0016:  /* 2C   | 0E               */ brfalse.s  IL_0026

    IL_0018:  /* 02   |                  */ ldarg.0
    IL_0019:  /* 07   |                  */ ldloc.1
    IL_001a:  /* 74   | (1B)00000D       */ castclass  class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object>/*1B00000D*/
    IL_001f:  /* 7D   | (04)000016       */ stfld      class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::externals /* 04000016 */
    IL_0024:  /* 2B   | 1D               */ br.s       IL_0043

    IL_0026:  /* 02   |                  */ ldarg.0
    IL_0027:  /* 72   | (70)000235       */ ldstr      "@" /* 70000235 */
    IL_002c:  /* 12   | 00               */ ldloca.s   V_0
    IL_002e:  /* 28   | (0A)000071       */ call       class [mscorlib/*23000001*/]System.Globalization.CultureInfo/*01000057*/ [mscorlib/*23000001*/]System.Globalization.CultureInfo/*01000057*/::get_InvariantCulture() /* 0A000071 */
    IL_0033:  /* 28   | (0A)000072       */ call       instance string [mscorlib/*23000001*/]System.Int32/*0100003C*/::ToString(class [mscorlib/*23000001*/]System.IFormatProvider/*01000058*/) /* 0A000072 */
    IL_0038:  /* 28   | (0A)000045       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(string,
                                                                                                                      string) /* 0A000045 */
    IL_003d:  /* 07   |                  */ ldloc.1
    IL_003e:  /* 28   | (06)000028       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::AddSymbol(string,
                                                                                                                                 object) /* 06000028 */
    IL_0043:  /* 06   |                  */ ldloc.0
    IL_0044:  /* 17   |                  */ ldc.i4.1
    IL_0045:  /* 58   |                  */ add
    IL_0046:  /* 0A   |                  */ stloc.0
    IL_0047:  /* 06   |                  */ ldloc.0
    IL_0048:  /* 03   |                  */ ldarg.1
    IL_0049:  /* 8E   |                  */ ldlen
    IL_004a:  /* 69   |                  */ conv.i4
    IL_004b:  /* 32   | B7               */ blt.s      IL_0004

    IL_004d:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ProcessValues

  .method /*06000028*/ private hidebysig 
          instance void  AddSymbol(string name,
                                   object 'value') cil managed
  // SIG: 20 02 01 0E 1C
  {
    // Method begins at RVA 0x2e98
    // Code size       52 (0x34)
    .maxstack  5
    .locals /*11000012*/ init (object[] V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000015       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::symbols /* 04000015 */
    IL_0006:  /* 03   |                  */ ldarg.1
    IL_0007:  /* 6F   | (0A)000073       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::ContainsKey(!0) /* 0A000073 */
    IL_000c:  /* 2C   | 18               */ brfalse.s  IL_0026

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 72   | (70)000239       */ ldstr      "The identifier '{0}' was defined more than once" /* 70000239 */
    IL_0014:  /* 17   |                  */ ldc.i4.1
    IL_0015:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_001a:  /* 0A   |                  */ stloc.0
    IL_001b:  /* 06   |                  */ ldloc.0
    IL_001c:  /* 16   |                  */ ldc.i4.0
    IL_001d:  /* 03   |                  */ ldarg.1
    IL_001e:  /* A2   |                  */ stelem.ref
    IL_001f:  /* 06   |                  */ ldloc.0
    IL_0020:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_0025:  /* 7A   |                  */ throw

    IL_0026:  /* 02   |                  */ ldarg.0
    IL_0027:  /* 7B   | (04)000015       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::symbols /* 04000015 */
    IL_002c:  /* 03   |                  */ ldarg.1
    IL_002d:  /* 04   |                  */ ldarg.2
    IL_002e:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_0033:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::AddSymbol

  .method /*06000029*/ public hidebysig instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          Parse(class [mscorlib/*23000001*/]System.Type/*01000008*/ resultType) cil managed
  // SIG: 20 01 12 25 12 21
  {
    // Method begins at RVA 0x2ed8
    // Code size       85 (0x55)
    .maxstack  6
    .locals /*11000013*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1,
             object[] V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_0012:  /* 0B   |                  */ stloc.1
    IL_0013:  /* 03   |                  */ ldarg.1
    IL_0014:  /* 14   |                  */ ldnull
    IL_0015:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_001a:  /* 2C   | 2B               */ brfalse.s  IL_0047

    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 07   |                  */ ldloc.1
    IL_001e:  /* 03   |                  */ ldarg.1
    IL_001f:  /* 17   |                  */ ldc.i4.1
    IL_0020:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_0025:  /* 25   |                  */ dup
    IL_0026:  /* 0B   |                  */ stloc.1
    IL_0027:  /* 2D   | 1E               */ brtrue.s   IL_0047

    IL_0029:  /* 02   |                  */ ldarg.0
    IL_002a:  /* 06   |                  */ ldloc.0
    IL_002b:  /* 72   | (70)000299       */ ldstr      "Expression of type '{0}' expected" /* 70000299 */
    IL_0030:  /* 17   |                  */ ldc.i4.1
    IL_0031:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0036:  /* 0C   |                  */ stloc.2
    IL_0037:  /* 08   |                  */ ldloc.2
    IL_0038:  /* 16   |                  */ ldc.i4.0
    IL_0039:  /* 03   |                  */ ldarg.1
    IL_003a:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_003f:  /* A2   |                  */ stelem.ref
    IL_0040:  /* 08   |                  */ ldloc.2
    IL_0041:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0046:  /* 7A   |                  */ throw

    IL_0047:  /* 02   |                  */ ldarg.0
    IL_0048:  /* 17   |                  */ ldc.i4.1
    IL_0049:  /* 72   | (70)0002DD       */ ldstr      "Syntax error" /* 700002DD */
    IL_004e:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0053:  /* 07   |                  */ ldloc.1
    IL_0054:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::Parse

  .method /*0600002A*/ public hidebysig instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/> 
          ParseOrdering() cil managed
  // SIG: 20 00 15 12 39 01 12 18
  {
    // Method begins at RVA 0x2f3c
    // Code size       147 (0x93)
    .maxstack  3
    .locals /*11000014*/ init (class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/> V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1,
             bool V_2,
             class System.Linq.Dynamic.DynamicOrdering/*02000006*/ V_3)
    IL_0000:  /* 73   | (0A)000075       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/>/*1B00000E*/::.ctor() /* 0A000075 */
    IL_0005:  /* 0A   |                  */ stloc.0
    IL_0006:  /* 02   |                  */ ldarg.0
    IL_0007:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_000c:  /* 0B   |                  */ stloc.1
    IL_000d:  /* 17   |                  */ ldc.i4.1
    IL_000e:  /* 0C   |                  */ stloc.2
    IL_000f:  /* 02   |                  */ ldarg.0
    IL_0010:  /* 72   | (70)0002F7       */ ldstr      "asc" /* 700002F7 */
    IL_0015:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_001a:  /* 2D   | 0D               */ brtrue.s   IL_0029

    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 72   | (70)0002FF       */ ldstr      "ascending" /* 700002FF */
    IL_0022:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0027:  /* 2C   | 08               */ brfalse.s  IL_0031

    IL_0029:  /* 02   |                  */ ldarg.0
    IL_002a:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_002f:  /* 2B   | 22               */ br.s       IL_0053

    IL_0031:  /* 02   |                  */ ldarg.0
    IL_0032:  /* 72   | (70)000313       */ ldstr      "desc" /* 70000313 */
    IL_0037:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_003c:  /* 2D   | 0D               */ brtrue.s   IL_004b

    IL_003e:  /* 02   |                  */ ldarg.0
    IL_003f:  /* 72   | (70)00031D       */ ldstr      "descending" /* 7000031D */
    IL_0044:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0049:  /* 2C   | 08               */ brfalse.s  IL_0053

    IL_004b:  /* 02   |                  */ ldarg.0
    IL_004c:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0051:  /* 16   |                  */ ldc.i4.0
    IL_0052:  /* 0C   |                  */ stloc.2
    IL_0053:  /* 06   |                  */ ldloc.0
    IL_0054:  /* 73   | (06)000016       */ newobj     instance void System.Linq.Dynamic.DynamicOrdering/*02000006*/::.ctor() /* 06000016 */
    IL_0059:  /* 0D   |                  */ stloc.3
    IL_005a:  /* 09   |                  */ ldloc.3
    IL_005b:  /* 07   |                  */ ldloc.1
    IL_005c:  /* 7D   | (04)000003       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.DynamicOrdering/*02000006*/::Selector /* 04000003 */
    IL_0061:  /* 09   |                  */ ldloc.3
    IL_0062:  /* 08   |                  */ ldloc.2
    IL_0063:  /* 7D   | (04)000004       */ stfld      bool System.Linq.Dynamic.DynamicOrdering/*02000006*/::Ascending /* 04000004 */
    IL_0068:  /* 09   |                  */ ldloc.3
    IL_0069:  /* 6F   | (0A)000076       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicOrdering/*02000006*/>/*1B00000E*/::Add(!0) /* 0A000076 */
    IL_006e:  /* 02   |                  */ ldarg.0
    IL_006f:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0074:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0079:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_007b:  /* 33   | 08               */ bne.un.s   IL_0085

    IL_007d:  /* 02   |                  */ ldarg.0
    IL_007e:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0083:  /* 2B   | 81               */ br.s       IL_0006

    IL_0085:  /* 02   |                  */ ldarg.0
    IL_0086:  /* 17   |                  */ ldc.i4.1
    IL_0087:  /* 72   | (70)0002DD       */ ldstr      "Syntax error" /* 700002DD */
    IL_008c:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0091:  /* 06   |                  */ ldloc.0
    IL_0092:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseOrdering

  .method /*0600002B*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseExpression() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x2fdc
    // Code size       86 (0x56)
    .maxstack  5
    .locals /*11000015*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 28   | (06)00002C       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseLogicalOr() /* 0600002C */
    IL_0012:  /* 0B   |                  */ stloc.1
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0019:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_001e:  /* 1F   | 15               */ ldc.i4.s   21
    IL_0020:  /* 33   | 32               */ bne.un.s   IL_0054

    IL_0022:  /* 02   |                  */ ldarg.0
    IL_0023:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0028:  /* 02   |                  */ ldarg.0
    IL_0029:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_002e:  /* 0C   |                  */ stloc.2
    IL_002f:  /* 02   |                  */ ldarg.0
    IL_0030:  /* 1F   | 11               */ ldc.i4.s   17
    IL_0032:  /* 72   | (70)000333       */ ldstr      "':' expected" /* 70000333 */
    IL_0037:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_003c:  /* 02   |                  */ ldarg.0
    IL_003d:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0042:  /* 02   |                  */ ldarg.0
    IL_0043:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_0048:  /* 0D   |                  */ stloc.3
    IL_0049:  /* 02   |                  */ ldarg.0
    IL_004a:  /* 07   |                  */ ldloc.1
    IL_004b:  /* 08   |                  */ ldloc.2
    IL_004c:  /* 09   |                  */ ldloc.3
    IL_004d:  /* 06   |                  */ ldloc.0
    IL_004e:  /* 28   | (06)00003C       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateConditional(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    int32) /* 0600003C */
    IL_0053:  /* 0B   |                  */ stloc.1
    IL_0054:  /* 07   |                  */ ldloc.1
    IL_0055:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseExpression

  .method /*0600002C*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseLogicalOr() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3040
    // Code size       101 (0x65)
    .maxstack  6
    .locals /*11000016*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00002D       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseLogicalAnd() /* 0600002D */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 2B   | 3E               */ br.s       IL_0047

    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000f:  /* 0B   |                  */ stloc.1
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0016:  /* 02   |                  */ ldarg.0
    IL_0017:  /* 28   | (06)00002D       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseLogicalAnd() /* 0600002D */
    IL_001c:  /* 0C   |                  */ stloc.2
    IL_001d:  /* 02   |                  */ ldarg.0
    IL_001e:  /* D0   | (02)00000D       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//ILogicalSignatures/*0200000D*/
    IL_0023:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0028:  /* 12   | 01               */ ldloca.s   V_1
    IL_002a:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_002f:  /* 12   | 00               */ ldloca.s   V_0
    IL_0031:  /* 12   | 02               */ ldloca.s   V_2
    IL_0033:  /* 12   | 01               */ ldloca.s   V_1
    IL_0035:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_003a:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_003f:  /* 06   |                  */ ldloc.0
    IL_0040:  /* 08   |                  */ ldloc.2
    IL_0041:  /* 28   | (0A)000077       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::OrElse(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000077 */
    IL_0046:  /* 0A   |                  */ stloc.0
    IL_0047:  /* 02   |                  */ ldarg.0
    IL_0048:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_004d:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0052:  /* 1F   | 1F               */ ldc.i4.s   31
    IL_0054:  /* 2E   | B3               */ beq.s      IL_0009

    IL_0056:  /* 02   |                  */ ldarg.0
    IL_0057:  /* 72   | (70)00034D       */ ldstr      "or" /* 7000034D */
    IL_005c:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0061:  /* 2D   | A6               */ brtrue.s   IL_0009

    IL_0063:  /* 06   |                  */ ldloc.0
    IL_0064:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseLogicalOr

  .method /*0600002D*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseLogicalAnd() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x30b4
    // Code size       101 (0x65)
    .maxstack  6
    .locals /*11000016*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00002E       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseComparison() /* 0600002E */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 2B   | 3E               */ br.s       IL_0047

    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000f:  /* 0B   |                  */ stloc.1
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0016:  /* 02   |                  */ ldarg.0
    IL_0017:  /* 28   | (06)00002E       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseComparison() /* 0600002E */
    IL_001c:  /* 0C   |                  */ stloc.2
    IL_001d:  /* 02   |                  */ ldarg.0
    IL_001e:  /* D0   | (02)00000D       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//ILogicalSignatures/*0200000D*/
    IL_0023:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0028:  /* 12   | 01               */ ldloca.s   V_1
    IL_002a:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_002f:  /* 12   | 00               */ ldloca.s   V_0
    IL_0031:  /* 12   | 02               */ ldloca.s   V_2
    IL_0033:  /* 12   | 01               */ ldloca.s   V_1
    IL_0035:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_003a:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_003f:  /* 06   |                  */ ldloc.0
    IL_0040:  /* 08   |                  */ ldloc.2
    IL_0041:  /* 28   | (0A)000078       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::AndAlso(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                            class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000078 */
    IL_0046:  /* 0A   |                  */ stloc.0
    IL_0047:  /* 02   |                  */ ldarg.0
    IL_0048:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_004d:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0052:  /* 1F   | 1A               */ ldc.i4.s   26
    IL_0054:  /* 2E   | B3               */ beq.s      IL_0009

    IL_0056:  /* 02   |                  */ ldarg.0
    IL_0057:  /* 72   | (70)000353       */ ldstr      "and" /* 70000353 */
    IL_005c:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0061:  /* 2D   | A6               */ brtrue.s   IL_0009

    IL_0063:  /* 06   |                  */ ldloc.0
    IL_0064:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseLogicalAnd

  .method /*0600002E*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseComparison() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3128
    // Code size       682 (0x2aa)
    .maxstack  6
    .locals /*11000017*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2,
             bool V_3,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_4,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ V_5)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00002F       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseAdditive() /* 0600002F */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 38   | 0C020000         */ br         IL_0218

    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0012:  /* 0B   |                  */ stloc.1
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 28   | (06)00002F       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseAdditive() /* 0600002F */
    IL_001f:  /* 0C   |                  */ stloc.2
    IL_0020:  /* 12   | 01               */ ldloca.s   V_1
    IL_0022:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0027:  /* 1F   | 13               */ ldc.i4.s   19
    IL_0029:  /* 2E   | 23               */ beq.s      IL_004e

    IL_002b:  /* 12   | 01               */ ldloca.s   V_1
    IL_002d:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0032:  /* 1F   | 1D               */ ldc.i4.s   29
    IL_0034:  /* 2E   | 18               */ beq.s      IL_004e

    IL_0036:  /* 12   | 01               */ ldloca.s   V_1
    IL_0038:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_003d:  /* 1F   | 19               */ ldc.i4.s   25
    IL_003f:  /* 2E   | 0D               */ beq.s      IL_004e

    IL_0041:  /* 12   | 01               */ ldloca.s   V_1
    IL_0043:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0048:  /* 1F   | 1C               */ ldc.i4.s   28
    IL_004a:  /* FE01 |                  */ ceq
    IL_004c:  /* 2B   | 01               */ br.s       IL_004f

    IL_004e:  /* 17   |                  */ ldc.i4.1
    IL_004f:  /* 0D   |                  */ stloc.3
    IL_0050:  /* 09   |                  */ ldloc.3
    IL_0051:  /* 39   | 94000000         */ brfalse    IL_00ea

    IL_0056:  /* 06   |                  */ ldloc.0
    IL_0057:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_005c:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0061:  /* 3A   | 84000000         */ brtrue     IL_00ea

    IL_0066:  /* 08   |                  */ ldloc.2
    IL_0067:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_006c:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0071:  /* 2D   | 77               */ brtrue.s   IL_00ea

    IL_0073:  /* 06   |                  */ ldloc.0
    IL_0074:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0079:  /* 08   |                  */ ldloc.2
    IL_007a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_007f:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0084:  /* 39   | 06010000         */ brfalse    IL_018f

    IL_0089:  /* 06   |                  */ ldloc.0
    IL_008a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_008f:  /* 08   |                  */ ldloc.2
    IL_0090:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0095:  /* 6F   | (0A)00007A       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::IsAssignableFrom(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007A */
    IL_009a:  /* 2C   | 12               */ brfalse.s  IL_00ae

    IL_009c:  /* 08   |                  */ ldloc.2
    IL_009d:  /* 06   |                  */ ldloc.0
    IL_009e:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00a3:  /* 28   | (0A)00007B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Convert(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007B */
    IL_00a8:  /* 0C   |                  */ stloc.2
    IL_00a9:  /* 38   | E1000000         */ br         IL_018f

    IL_00ae:  /* 08   |                  */ ldloc.2
    IL_00af:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00b4:  /* 06   |                  */ ldloc.0
    IL_00b5:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00ba:  /* 6F   | (0A)00007A       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::IsAssignableFrom(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007A */
    IL_00bf:  /* 2C   | 12               */ brfalse.s  IL_00d3

    IL_00c1:  /* 06   |                  */ ldloc.0
    IL_00c2:  /* 08   |                  */ ldloc.2
    IL_00c3:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00c8:  /* 28   | (0A)00007B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Convert(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007B */
    IL_00cd:  /* 0A   |                  */ stloc.0
    IL_00ce:  /* 38   | BC000000         */ br         IL_018f

    IL_00d3:  /* 02   |                  */ ldarg.0
    IL_00d4:  /* 12   | 01               */ ldloca.s   V_1
    IL_00d6:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_00db:  /* 06   |                  */ ldloc.0
    IL_00dc:  /* 08   |                  */ ldloc.2
    IL_00dd:  /* 12   | 01               */ ldloca.s   V_1
    IL_00df:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_00e4:  /* 28   | (06)000052       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::IncompatibleOperandsError(string,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     int32) /* 06000052 */
    IL_00e9:  /* 7A   |                  */ throw

    IL_00ea:  /* 06   |                  */ ldloc.0
    IL_00eb:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00f0:  /* 28   | (06)00004F       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsEnumType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004F */
    IL_00f5:  /* 2D   | 0D               */ brtrue.s   IL_0104

    IL_00f7:  /* 08   |                  */ ldloc.2
    IL_00f8:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00fd:  /* 28   | (06)00004F       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsEnumType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004F */
    IL_0102:  /* 2C   | 5A               */ brfalse.s  IL_015e

    IL_0104:  /* 06   |                  */ ldloc.0
    IL_0105:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_010a:  /* 08   |                  */ ldloc.2
    IL_010b:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0110:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0115:  /* 2C   | 78               */ brfalse.s  IL_018f

    IL_0117:  /* 02   |                  */ ldarg.0
    IL_0118:  /* 08   |                  */ ldloc.2
    IL_0119:  /* 06   |                  */ ldloc.0
    IL_011a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_011f:  /* 17   |                  */ ldc.i4.1
    IL_0120:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_0125:  /* 25   |                  */ dup
    IL_0126:  /* 13   | 04               */ stloc.s    V_4
    IL_0128:  /* 2C   | 05               */ brfalse.s  IL_012f

    IL_012a:  /* 11   | 04               */ ldloc.s    V_4
    IL_012c:  /* 0C   |                  */ stloc.2
    IL_012d:  /* 2B   | 60               */ br.s       IL_018f

    IL_012f:  /* 02   |                  */ ldarg.0
    IL_0130:  /* 06   |                  */ ldloc.0
    IL_0131:  /* 08   |                  */ ldloc.2
    IL_0132:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0137:  /* 17   |                  */ ldc.i4.1
    IL_0138:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_013d:  /* 25   |                  */ dup
    IL_013e:  /* 13   | 04               */ stloc.s    V_4
    IL_0140:  /* 2C   | 05               */ brfalse.s  IL_0147

    IL_0142:  /* 11   | 04               */ ldloc.s    V_4
    IL_0144:  /* 0A   |                  */ stloc.0
    IL_0145:  /* 2B   | 48               */ br.s       IL_018f

    IL_0147:  /* 02   |                  */ ldarg.0
    IL_0148:  /* 12   | 01               */ ldloca.s   V_1
    IL_014a:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_014f:  /* 06   |                  */ ldloc.0
    IL_0150:  /* 08   |                  */ ldloc.2
    IL_0151:  /* 12   | 01               */ ldloca.s   V_1
    IL_0153:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0158:  /* 28   | (06)000052       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::IncompatibleOperandsError(string,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     int32) /* 06000052 */
    IL_015d:  /* 7A   |                  */ throw

    IL_015e:  /* 02   |                  */ ldarg.0
    IL_015f:  /* 09   |                  */ ldloc.3
    IL_0160:  /* 2D   | 0C               */ brtrue.s   IL_016e

    IL_0162:  /* D0   | (02)00000F       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//IRelationalSignatures/*0200000F*/
    IL_0167:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_016c:  /* 2B   | 0A               */ br.s       IL_0178

    IL_016e:  /* D0   | (02)000010       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//IEqualitySignatures/*02000010*/
    IL_0173:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0178:  /* 12   | 01               */ ldloca.s   V_1
    IL_017a:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_017f:  /* 12   | 00               */ ldloca.s   V_0
    IL_0181:  /* 12   | 02               */ ldloca.s   V_2
    IL_0183:  /* 12   | 01               */ ldloca.s   V_1
    IL_0185:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_018a:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_018f:  /* 12   | 01               */ ldloca.s   V_1
    IL_0191:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0196:  /* 13   | 05               */ stloc.s    V_5
    IL_0198:  /* 11   | 05               */ ldloc.s    V_5
    IL_019a:  /* 1F   | 12               */ ldc.i4.s   18
    IL_019c:  /* 59   |                  */ sub
    IL_019d:  /* 45   | 0D000000         */ switch     ( 
              /*      | 2E000000         */             IL_0204,
              /*      | 02000000         */             IL_01d8,
              /*      | 18000000         */             IL_01ee,
              /*      | 42000000         */             IL_0218,
              /*      | 42000000         */             IL_0218,
              /*      | 42000000         */             IL_0218,
              /*      | 42000000         */             IL_0218,
              /*      | 0D000000         */             IL_01e3,
              /*      | 42000000         */             IL_0218,
              /*      | 39000000         */             IL_020f,
              /*      | 0D000000         */             IL_01e3,
              /*      | 02000000         */             IL_01d8,
              /*      | 23000000         */             IL_01f9)
    IL_01d6:  /* 2B   | 40               */ br.s       IL_0218

    IL_01d8:  /* 02   |                  */ ldarg.0
    IL_01d9:  /* 06   |                  */ ldloc.0
    IL_01da:  /* 08   |                  */ ldloc.2
    IL_01db:  /* 28   | (06)000061       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000061 */
    IL_01e0:  /* 0A   |                  */ stloc.0
    IL_01e1:  /* 2B   | 35               */ br.s       IL_0218

    IL_01e3:  /* 02   |                  */ ldarg.0
    IL_01e4:  /* 06   |                  */ ldloc.0
    IL_01e5:  /* 08   |                  */ ldloc.2
    IL_01e6:  /* 28   | (06)000062       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateNotEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                 class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000062 */
    IL_01eb:  /* 0A   |                  */ stloc.0
    IL_01ec:  /* 2B   | 2A               */ br.s       IL_0218

    IL_01ee:  /* 02   |                  */ ldarg.0
    IL_01ef:  /* 06   |                  */ ldloc.0
    IL_01f0:  /* 08   |                  */ ldloc.2
    IL_01f1:  /* 28   | (06)000063       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateGreaterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000063 */
    IL_01f6:  /* 0A   |                  */ stloc.0
    IL_01f7:  /* 2B   | 1F               */ br.s       IL_0218

    IL_01f9:  /* 02   |                  */ ldarg.0
    IL_01fa:  /* 06   |                  */ ldloc.0
    IL_01fb:  /* 08   |                  */ ldloc.2
    IL_01fc:  /* 28   | (06)000064       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateGreaterThanEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000064 */
    IL_0201:  /* 0A   |                  */ stloc.0
    IL_0202:  /* 2B   | 14               */ br.s       IL_0218

    IL_0204:  /* 02   |                  */ ldarg.0
    IL_0205:  /* 06   |                  */ ldloc.0
    IL_0206:  /* 08   |                  */ ldloc.2
    IL_0207:  /* 28   | (06)000065       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateLessThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                 class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000065 */
    IL_020c:  /* 0A   |                  */ stloc.0
    IL_020d:  /* 2B   | 09               */ br.s       IL_0218

    IL_020f:  /* 02   |                  */ ldarg.0
    IL_0210:  /* 06   |                  */ ldloc.0
    IL_0211:  /* 08   |                  */ ldloc.2
    IL_0212:  /* 28   | (06)000066       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateLessThanEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000066 */
    IL_0217:  /* 0A   |                  */ stloc.0
    IL_0218:  /* 02   |                  */ ldarg.0
    IL_0219:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_021e:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0223:  /* 1F   | 13               */ ldc.i4.s   19
    IL_0225:  /* 3B   | E2FDFFFF         */ beq        IL_000c

    IL_022a:  /* 02   |                  */ ldarg.0
    IL_022b:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0230:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0235:  /* 1F   | 1D               */ ldc.i4.s   29
    IL_0237:  /* 3B   | D0FDFFFF         */ beq        IL_000c

    IL_023c:  /* 02   |                  */ ldarg.0
    IL_023d:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0242:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0247:  /* 1F   | 19               */ ldc.i4.s   25
    IL_0249:  /* 3B   | BEFDFFFF         */ beq        IL_000c

    IL_024e:  /* 02   |                  */ ldarg.0
    IL_024f:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0254:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0259:  /* 1F   | 1C               */ ldc.i4.s   28
    IL_025b:  /* 3B   | ACFDFFFF         */ beq        IL_000c

    IL_0260:  /* 02   |                  */ ldarg.0
    IL_0261:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0266:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_026b:  /* 1F   | 14               */ ldc.i4.s   20
    IL_026d:  /* 3B   | 9AFDFFFF         */ beq        IL_000c

    IL_0272:  /* 02   |                  */ ldarg.0
    IL_0273:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0278:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_027d:  /* 1F   | 1E               */ ldc.i4.s   30
    IL_027f:  /* 3B   | 88FDFFFF         */ beq        IL_000c

    IL_0284:  /* 02   |                  */ ldarg.0
    IL_0285:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_028a:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_028f:  /* 1F   | 12               */ ldc.i4.s   18
    IL_0291:  /* 3B   | 76FDFFFF         */ beq        IL_000c

    IL_0296:  /* 02   |                  */ ldarg.0
    IL_0297:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_029c:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_02a1:  /* 1F   | 1B               */ ldc.i4.s   27
    IL_02a3:  /* 3B   | 64FDFFFF         */ beq        IL_000c

    IL_02a8:  /* 06   |                  */ ldloc.0
    IL_02a9:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseComparison

  .method /*0600002F*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseAdditive() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x33e0
    // Code size       273 (0x111)
    .maxstack  6
    .locals /*11000018*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000030       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseMultiplicative() /* 06000030 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 38   | CE000000         */ br         IL_00da

    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0012:  /* 0B   |                  */ stloc.1
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 28   | (06)000030       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseMultiplicative() /* 06000030 */
    IL_001f:  /* 0C   |                  */ stloc.2
    IL_0020:  /* 12   | 01               */ ldloca.s   V_1
    IL_0022:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0027:  /* 0D   |                  */ stloc.3
    IL_0028:  /* 09   |                  */ ldloc.3
    IL_0029:  /* 1E   |                  */ ldc.i4.8
    IL_002a:  /* 3B   | A2000000         */ beq        IL_00d1

    IL_002f:  /* 09   |                  */ ldloc.3
    IL_0030:  /* 1F   | 0C               */ ldc.i4.s   12
    IL_0032:  /* 59   |                  */ sub
    IL_0033:  /* 45   | 03000000         */ switch     ( 
              /*      | 05000000         */             IL_0049,
              /*      | 96000000         */             IL_00da,
              /*      | 60000000         */             IL_00a4)
    IL_0044:  /* 38   | 91000000         */ br         IL_00da

    IL_0049:  /* 06   |                  */ ldloc.0
    IL_004a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_004f:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_0054:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0059:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_005e:  /* 2D   | 71               */ brtrue.s   IL_00d1

    IL_0060:  /* 08   |                  */ ldloc.2
    IL_0061:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0066:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_006b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0070:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0075:  /* 2D   | 5A               */ brtrue.s   IL_00d1

    IL_0077:  /* 02   |                  */ ldarg.0
    IL_0078:  /* D0   | (02)000011       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//IAddSignatures/*02000011*/
    IL_007d:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0082:  /* 12   | 01               */ ldloca.s   V_1
    IL_0084:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0089:  /* 12   | 00               */ ldloca.s   V_0
    IL_008b:  /* 12   | 02               */ ldloca.s   V_2
    IL_008d:  /* 12   | 01               */ ldloca.s   V_1
    IL_008f:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0094:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_0099:  /* 02   |                  */ ldarg.0
    IL_009a:  /* 06   |                  */ ldloc.0
    IL_009b:  /* 08   |                  */ ldloc.2
    IL_009c:  /* 28   | (06)000067       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateAdd(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                            class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000067 */
    IL_00a1:  /* 0A   |                  */ stloc.0
    IL_00a2:  /* 2B   | 36               */ br.s       IL_00da

    IL_00a4:  /* 02   |                  */ ldarg.0
    IL_00a5:  /* D0   | (02)000012       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//ISubtractSignatures/*02000012*/
    IL_00aa:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00af:  /* 12   | 01               */ ldloca.s   V_1
    IL_00b1:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_00b6:  /* 12   | 00               */ ldloca.s   V_0
    IL_00b8:  /* 12   | 02               */ ldloca.s   V_2
    IL_00ba:  /* 12   | 01               */ ldloca.s   V_1
    IL_00bc:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_00c1:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_00c6:  /* 02   |                  */ ldarg.0
    IL_00c7:  /* 06   |                  */ ldloc.0
    IL_00c8:  /* 08   |                  */ ldloc.2
    IL_00c9:  /* 28   | (06)000068       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateSubtract(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                 class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000068 */
    IL_00ce:  /* 0A   |                  */ stloc.0
    IL_00cf:  /* 2B   | 09               */ br.s       IL_00da

    IL_00d1:  /* 02   |                  */ ldarg.0
    IL_00d2:  /* 06   |                  */ ldloc.0
    IL_00d3:  /* 08   |                  */ ldloc.2
    IL_00d4:  /* 28   | (06)000069       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStringConcat(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000069 */
    IL_00d9:  /* 0A   |                  */ stloc.0
    IL_00da:  /* 02   |                  */ ldarg.0
    IL_00db:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_00e0:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_00e5:  /* 1F   | 0C               */ ldc.i4.s   12
    IL_00e7:  /* 3B   | 20FFFFFF         */ beq        IL_000c

    IL_00ec:  /* 02   |                  */ ldarg.0
    IL_00ed:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_00f2:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_00f7:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_00f9:  /* 3B   | 0EFFFFFF         */ beq        IL_000c

    IL_00fe:  /* 02   |                  */ ldarg.0
    IL_00ff:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0104:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0109:  /* 1E   |                  */ ldc.i4.8
    IL_010a:  /* 3B   | FDFEFFFF         */ beq        IL_000c

    IL_010f:  /* 06   |                  */ ldloc.0
    IL_0110:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseAdditive

  .method /*06000030*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseMultiplicative() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3500
    // Code size       196 (0xc4)
    .maxstack  6
    .locals /*11000018*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2,
             valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000031       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseUnary() /* 06000031 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 2B   | 74               */ br.s       IL_007d

    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000f:  /* 0B   |                  */ stloc.1
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0016:  /* 02   |                  */ ldarg.0
    IL_0017:  /* 28   | (06)000031       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseUnary() /* 06000031 */
    IL_001c:  /* 0C   |                  */ stloc.2
    IL_001d:  /* 02   |                  */ ldarg.0
    IL_001e:  /* D0   | (02)00000E       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//IArithmeticSignatures/*0200000E*/
    IL_0023:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0028:  /* 12   | 01               */ ldloca.s   V_1
    IL_002a:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_002f:  /* 12   | 00               */ ldloca.s   V_0
    IL_0031:  /* 12   | 02               */ ldloca.s   V_2
    IL_0033:  /* 12   | 01               */ ldloca.s   V_1
    IL_0035:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_003a:  /* 28   | (06)000051       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                               string,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                               int32) /* 06000051 */
    IL_003f:  /* 12   | 01               */ ldloca.s   V_1
    IL_0041:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0046:  /* 0D   |                  */ stloc.3
    IL_0047:  /* 09   |                  */ ldloc.3
    IL_0048:  /* 1D   |                  */ ldc.i4.7
    IL_0049:  /* 30   | 0A               */ bgt.s      IL_0055

    IL_004b:  /* 09   |                  */ ldloc.3
    IL_004c:  /* 18   |                  */ ldc.i4.2
    IL_004d:  /* 2E   | 26               */ beq.s      IL_0075

    IL_004f:  /* 09   |                  */ ldloc.3
    IL_0050:  /* 1D   |                  */ ldc.i4.7
    IL_0051:  /* 2E   | 22               */ beq.s      IL_0075

    IL_0053:  /* 2B   | 28               */ br.s       IL_007d

    IL_0055:  /* 09   |                  */ ldloc.3
    IL_0056:  /* 1F   | 0B               */ ldc.i4.s   11
    IL_0058:  /* 2E   | 07               */ beq.s      IL_0061

    IL_005a:  /* 09   |                  */ ldloc.3
    IL_005b:  /* 1F   | 10               */ ldc.i4.s   16
    IL_005d:  /* 2E   | 0C               */ beq.s      IL_006b

    IL_005f:  /* 2B   | 1C               */ br.s       IL_007d

    IL_0061:  /* 06   |                  */ ldloc.0
    IL_0062:  /* 08   |                  */ ldloc.2
    IL_0063:  /* 28   | (0A)00007C       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Multiply(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00007C */
    IL_0068:  /* 0A   |                  */ stloc.0
    IL_0069:  /* 2B   | 12               */ br.s       IL_007d

    IL_006b:  /* 06   |                  */ ldloc.0
    IL_006c:  /* 08   |                  */ ldloc.2
    IL_006d:  /* 28   | (0A)00007D       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Divide(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00007D */
    IL_0072:  /* 0A   |                  */ stloc.0
    IL_0073:  /* 2B   | 08               */ br.s       IL_007d

    IL_0075:  /* 06   |                  */ ldloc.0
    IL_0076:  /* 08   |                  */ ldloc.2
    IL_0077:  /* 28   | (0A)00007E       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Modulo(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00007E */
    IL_007c:  /* 0A   |                  */ stloc.0
    IL_007d:  /* 02   |                  */ ldarg.0
    IL_007e:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0083:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0088:  /* 1F   | 0B               */ ldc.i4.s   11
    IL_008a:  /* 3B   | 7AFFFFFF         */ beq        IL_0009

    IL_008f:  /* 02   |                  */ ldarg.0
    IL_0090:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0095:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_009a:  /* 1F   | 10               */ ldc.i4.s   16
    IL_009c:  /* 3B   | 68FFFFFF         */ beq        IL_0009

    IL_00a1:  /* 02   |                  */ ldarg.0
    IL_00a2:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_00a7:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_00ac:  /* 1D   |                  */ ldc.i4.7
    IL_00ad:  /* 3B   | 57FFFFFF         */ beq        IL_0009

    IL_00b2:  /* 02   |                  */ ldarg.0
    IL_00b3:  /* 72   | (70)00035B       */ ldstr      "mod" /* 7000035B */
    IL_00b8:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_00bd:  /* 3A   | 47FFFFFF         */ brtrue     IL_0009

    IL_00c2:  /* 06   |                  */ ldloc.0
    IL_00c3:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseMultiplicative

  .method /*06000031*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseUnary() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x35d0
    // Code size       261 (0x105)
    .maxstack  5
    .locals /*11000019*/ init (valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_000b:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_000d:  /* 2E   | 1E               */ beq.s      IL_002d

    IL_000f:  /* 02   |                  */ ldarg.0
    IL_0010:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0015:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_001a:  /* 1C   |                  */ ldc.i4.6
    IL_001b:  /* 2E   | 10               */ beq.s      IL_002d

    IL_001d:  /* 02   |                  */ ldarg.0
    IL_001e:  /* 72   | (70)000363       */ ldstr      "not" /* 70000363 */
    IL_0023:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0028:  /* 39   | D1000000         */ brfalse    IL_00fe

    IL_002d:  /* 02   |                  */ ldarg.0
    IL_002e:  /* 7B   | (04)00001D       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0033:  /* 0A   |                  */ stloc.0
    IL_0034:  /* 02   |                  */ ldarg.0
    IL_0035:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_003a:  /* 12   | 00               */ ldloca.s   V_0
    IL_003c:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0041:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_0043:  /* 33   | 55               */ bne.un.s   IL_009a

    IL_0045:  /* 02   |                  */ ldarg.0
    IL_0046:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_004b:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0050:  /* 1A   |                  */ ldc.i4.4
    IL_0051:  /* 2E   | 0E               */ beq.s      IL_0061

    IL_0053:  /* 02   |                  */ ldarg.0
    IL_0054:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0059:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_005e:  /* 1B   |                  */ ldc.i4.5
    IL_005f:  /* 33   | 39               */ bne.un.s   IL_009a

    IL_0061:  /* 02   |                  */ ldarg.0
    IL_0062:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0067:  /* 72   | (70)00036B       */ ldstr      "-" /* 7000036B */
    IL_006c:  /* 02   |                  */ ldarg.0
    IL_006d:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0072:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0077:  /* 28   | (0A)000045       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(string,
                                                                                                                      string) /* 0A000045 */
    IL_007c:  /* 7D   | (04)000022       */ stfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0081:  /* 02   |                  */ ldarg.0
    IL_0082:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0087:  /* 12   | 00               */ ldloca.s   V_0
    IL_0089:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_008e:  /* 7D   | (04)000023       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0093:  /* 02   |                  */ ldarg.0
    IL_0094:  /* 28   | (06)000032       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParsePrimary() /* 06000032 */
    IL_0099:  /* 2A   |                  */ ret

    IL_009a:  /* 02   |                  */ ldarg.0
    IL_009b:  /* 28   | (06)000031       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseUnary() /* 06000031 */
    IL_00a0:  /* 0B   |                  */ stloc.1
    IL_00a1:  /* 12   | 00               */ ldloca.s   V_0
    IL_00a3:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_00a8:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_00aa:  /* 33   | 29               */ bne.un.s   IL_00d5

    IL_00ac:  /* 02   |                  */ ldarg.0
    IL_00ad:  /* D0   | (02)000013       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//INegationSignatures/*02000013*/
    IL_00b2:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00b7:  /* 12   | 00               */ ldloca.s   V_0
    IL_00b9:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_00be:  /* 12   | 01               */ ldloca.s   V_1
    IL_00c0:  /* 12   | 00               */ ldloca.s   V_0
    IL_00c2:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_00c7:  /* 28   | (06)000050       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperand(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                              string,
                                                                                                                                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                              int32) /* 06000050 */
    IL_00cc:  /* 07   |                  */ ldloc.1
    IL_00cd:  /* 28   | (0A)00007F       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Negate(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00007F */
    IL_00d2:  /* 0B   |                  */ stloc.1
    IL_00d3:  /* 2B   | 27               */ br.s       IL_00fc

    IL_00d5:  /* 02   |                  */ ldarg.0
    IL_00d6:  /* D0   | (02)000014       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//INotSignatures/*02000014*/
    IL_00db:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00e0:  /* 12   | 00               */ ldloca.s   V_0
    IL_00e2:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_00e7:  /* 12   | 01               */ ldloca.s   V_1
    IL_00e9:  /* 12   | 00               */ ldloca.s   V_0
    IL_00eb:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_00f0:  /* 28   | (06)000050       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::CheckAndPromoteOperand(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                              string,
                                                                                                                                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/&,
                                                                                                                                              int32) /* 06000050 */
    IL_00f5:  /* 07   |                  */ ldloc.1
    IL_00f6:  /* 28   | (0A)000080       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Not(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000080 */
    IL_00fb:  /* 0B   |                  */ stloc.1
    IL_00fc:  /* 07   |                  */ ldloc.1
    IL_00fd:  /* 2A   |                  */ ret

    IL_00fe:  /* 02   |                  */ ldarg.0
    IL_00ff:  /* 28   | (06)000032       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParsePrimary() /* 06000032 */
    IL_0104:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseUnary

  .method /*06000032*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParsePrimary() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x36e4
    // Code size       66 (0x42)
    .maxstack  3
    .locals /*1100001A*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000033       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParsePrimaryStart() /* 06000033 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000d:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0012:  /* 1F   | 0F               */ ldc.i4.s   15
    IL_0014:  /* 33   | 11               */ bne.un.s   IL_0027

    IL_0016:  /* 02   |                  */ ldarg.0
    IL_0017:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 14   |                  */ ldnull
    IL_001e:  /* 06   |                  */ ldloc.0
    IL_001f:  /* 28   | (06)000041       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseMemberAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000041 */
    IL_0024:  /* 0A   |                  */ stloc.0
    IL_0025:  /* 2B   | E0               */ br.s       IL_0007

    IL_0027:  /* 02   |                  */ ldarg.0
    IL_0028:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_002d:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0032:  /* 1F   | 16               */ ldc.i4.s   22
    IL_0034:  /* 33   | 0A               */ bne.un.s   IL_0040

    IL_0036:  /* 02   |                  */ ldarg.0
    IL_0037:  /* 06   |                  */ ldloc.0
    IL_0038:  /* 28   | (06)000046       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseElementAccess(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000046 */
    IL_003d:  /* 0A   |                  */ stloc.0
    IL_003e:  /* 2B   | C7               */ br.s       IL_0007

    IL_0040:  /* 06   |                  */ ldloc.0
    IL_0041:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParsePrimary

  .method /*06000033*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParsePrimaryStart() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3734
    // Code size       107 (0x6b)
    .maxstack  3
    .locals /*1100001B*/ init (valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 06   |                  */ ldloc.0
    IL_000d:  /* 18   |                  */ ldc.i4.2
    IL_000e:  /* 59   |                  */ sub
    IL_000f:  /* 45   | 08000000         */ switch     ( 
              /*      | 02000000         */             IL_0036,
              /*      | 09000000         */             IL_003d,
              /*      | 10000000         */             IL_0044,
              /*      | 17000000         */             IL_004b,
              /*      | 25000000         */             IL_0059,
              /*      | 25000000         */             IL_0059,
              /*      | 25000000         */             IL_0059,
              /*      | 1E000000         */             IL_0052)
    IL_0034:  /* 2B   | 23               */ br.s       IL_0059

    IL_0036:  /* 02   |                  */ ldarg.0
    IL_0037:  /* 28   | (06)000039       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseIdentifier() /* 06000039 */
    IL_003c:  /* 2A   |                  */ ret

    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 28   | (06)000034       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseStringLiteral() /* 06000034 */
    IL_0043:  /* 2A   |                  */ ret

    IL_0044:  /* 02   |                  */ ldarg.0
    IL_0045:  /* 28   | (06)000035       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseIntegerLiteral() /* 06000035 */
    IL_004a:  /* 2A   |                  */ ret

    IL_004b:  /* 02   |                  */ ldarg.0
    IL_004c:  /* 28   | (06)000036       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseRealLiteral() /* 06000036 */
    IL_0051:  /* 2A   |                  */ ret

    IL_0052:  /* 02   |                  */ ldarg.0
    IL_0053:  /* 28   | (06)000038       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseParenExpression() /* 06000038 */
    IL_0058:  /* 2A   |                  */ ret

    IL_0059:  /* 02   |                  */ ldarg.0
    IL_005a:  /* 72   | (70)00036F       */ ldstr      "Expression expected" /* 7000036F */
    IL_005f:  /* 16   |                  */ ldc.i4.0
    IL_0060:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0065:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_006a:  /* 7A   |                  */ throw
  } // end of method ExpressionParser::ParsePrimaryStart

  .method /*06000034*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseStringLiteral() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x37ac
    // Code size       164 (0xa4)
    .maxstack  4
    .locals /*1100001C*/ init (char V_0,
             string V_1,
             int32 V_2,
             int32 V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 19   |                  */ ldc.i4.3
    IL_0002:  /* 28   | (06)000073       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/) /* 06000073 */
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000d:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0012:  /* 16   |                  */ ldc.i4.0
    IL_0013:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_0018:  /* 0A   |                  */ stloc.0
    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_001f:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0024:  /* 17   |                  */ ldc.i4.1
    IL_0025:  /* 02   |                  */ ldarg.0
    IL_0026:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_002b:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0030:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_0035:  /* 18   |                  */ ldc.i4.2
    IL_0036:  /* 59   |                  */ sub
    IL_0037:  /* 6F   | (0A)000082       */ callvirt   instance string [mscorlib/*23000001*/]System.String/*01000042*/::Substring(int32,
                                                                                                                                  int32) /* 0A000082 */
    IL_003c:  /* 0B   |                  */ stloc.1
    IL_003d:  /* 16   |                  */ ldc.i4.0
    IL_003e:  /* 0C   |                  */ stloc.2
    IL_003f:  /* 07   |                  */ ldloc.1
    IL_0040:  /* 06   |                  */ ldloc.0
    IL_0041:  /* 08   |                  */ ldloc.2
    IL_0042:  /* 6F   | (0A)000083       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::IndexOf(char,
                                                                                                                               int32) /* 0A000083 */
    IL_0047:  /* 0D   |                  */ stloc.3
    IL_0048:  /* 09   |                  */ ldloc.3
    IL_0049:  /* 16   |                  */ ldc.i4.0
    IL_004a:  /* 32   | 0F               */ blt.s      IL_005b

    IL_004c:  /* 07   |                  */ ldloc.1
    IL_004d:  /* 09   |                  */ ldloc.3
    IL_004e:  /* 17   |                  */ ldc.i4.1
    IL_004f:  /* 6F   | (0A)000084       */ callvirt   instance string [mscorlib/*23000001*/]System.String/*01000042*/::Remove(int32,
                                                                                                                               int32) /* 0A000084 */
    IL_0054:  /* 0B   |                  */ stloc.1
    IL_0055:  /* 09   |                  */ ldloc.3
    IL_0056:  /* 17   |                  */ ldc.i4.1
    IL_0057:  /* 58   |                  */ add
    IL_0058:  /* 0C   |                  */ stloc.2
    IL_0059:  /* 2B   | E4               */ br.s       IL_003f

    IL_005b:  /* 06   |                  */ ldloc.0
    IL_005c:  /* 1F   | 27               */ ldc.i4.s   39
    IL_005e:  /* 33   | 35               */ bne.un.s   IL_0095

    IL_0060:  /* 07   |                  */ ldloc.1
    IL_0061:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_0066:  /* 17   |                  */ ldc.i4.1
    IL_0067:  /* 2E   | 12               */ beq.s      IL_007b

    IL_0069:  /* 02   |                  */ ldarg.0
    IL_006a:  /* 72   | (70)000397       */ ldstr      "Character literal must contain exactly one character" /* 70000397 */
    IL_006f:  /* 16   |                  */ ldc.i4.0
    IL_0070:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0075:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_007a:  /* 7A   |                  */ throw

    IL_007b:  /* 02   |                  */ ldarg.0
    IL_007c:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0081:  /* 02   |                  */ ldarg.0
    IL_0082:  /* 07   |                  */ ldloc.1
    IL_0083:  /* 16   |                  */ ldc.i4.0
    IL_0084:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_0089:  /* 8C   | (01)00005A       */ box        [mscorlib/*23000001*/]System.Char/*0100005A*/
    IL_008e:  /* 07   |                  */ ldloc.1
    IL_008f:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_0094:  /* 2A   |                  */ ret

    IL_0095:  /* 02   |                  */ ldarg.0
    IL_0096:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_009b:  /* 02   |                  */ ldarg.0
    IL_009c:  /* 07   |                  */ ldloc.1
    IL_009d:  /* 07   |                  */ ldloc.1
    IL_009e:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_00a3:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseStringLiteral

  .method /*06000035*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseIntegerLiteral() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x385c
    // Code size       244 (0xf4)
    .maxstack  5
    .locals /*1100001D*/ init (string V_0,
             uint64 V_1,
             int64 V_2,
             object[] V_3,
             object[] V_4)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 1A   |                  */ ldc.i4.4
    IL_0002:  /* 28   | (06)000073       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/) /* 06000073 */
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000d:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0012:  /* 0A   |                  */ stloc.0
    IL_0013:  /* 06   |                  */ ldloc.0
    IL_0014:  /* 16   |                  */ ldc.i4.0
    IL_0015:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_001a:  /* 1F   | 2D               */ ldc.i4.s   45
    IL_001c:  /* 2E   | 7C               */ beq.s      IL_009a

    IL_001e:  /* 06   |                  */ ldloc.0
    IL_001f:  /* 12   | 01               */ ldloca.s   V_1
    IL_0021:  /* 28   | (0A)000085       */ call       bool [mscorlib/*23000001*/]System.UInt64/*0100005B*/::TryParse(string,
                                                                                                                      uint64&) /* 0A000085 */
    IL_0026:  /* 2D   | 18               */ brtrue.s   IL_0040

    IL_0028:  /* 02   |                  */ ldarg.0
    IL_0029:  /* 72   | (70)000401       */ ldstr      "Invalid integer literal '{0}'" /* 70000401 */
    IL_002e:  /* 17   |                  */ ldc.i4.1
    IL_002f:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0034:  /* 0D   |                  */ stloc.3
    IL_0035:  /* 09   |                  */ ldloc.3
    IL_0036:  /* 16   |                  */ ldc.i4.0
    IL_0037:  /* 06   |                  */ ldloc.0
    IL_0038:  /* A2   |                  */ stelem.ref
    IL_0039:  /* 09   |                  */ ldloc.3
    IL_003a:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_003f:  /* 7A   |                  */ throw

    IL_0040:  /* 02   |                  */ ldarg.0
    IL_0041:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0046:  /* 07   |                  */ ldloc.1
    IL_0047:  /* 20   | FFFFFF7F         */ ldc.i4     0x7fffffff
    IL_004c:  /* 6A   |                  */ conv.i8
    IL_004d:  /* 35   | 0F               */ bgt.un.s   IL_005e

    IL_004f:  /* 02   |                  */ ldarg.0
    IL_0050:  /* 07   |                  */ ldloc.1
    IL_0051:  /* 69   |                  */ conv.i4
    IL_0052:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0057:  /* 06   |                  */ ldloc.0
    IL_0058:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_005d:  /* 2A   |                  */ ret

    IL_005e:  /* 07   |                  */ ldloc.1
    IL_005f:  /* 15   |                  */ ldc.i4.m1
    IL_0060:  /* 6E   |                  */ conv.u8
    IL_0061:  /* 35   | 0F               */ bgt.un.s   IL_0072

    IL_0063:  /* 02   |                  */ ldarg.0
    IL_0064:  /* 07   |                  */ ldloc.1
    IL_0065:  /* 6D   |                  */ conv.u4
    IL_0066:  /* 8C   | (01)00005C       */ box        [mscorlib/*23000001*/]System.UInt32/*0100005C*/
    IL_006b:  /* 06   |                  */ ldloc.0
    IL_006c:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_0071:  /* 2A   |                  */ ret

    IL_0072:  /* 07   |                  */ ldloc.1
    IL_0073:  /* 21   | FFFFFFFFFFFFFF7F */ ldc.i8     0x7fffffffffffffff
    IL_007c:  /* 35   | 0E               */ bgt.un.s   IL_008c

    IL_007e:  /* 02   |                  */ ldarg.0
    IL_007f:  /* 07   |                  */ ldloc.1
    IL_0080:  /* 8C   | (01)00005D       */ box        [mscorlib/*23000001*/]System.Int64/*0100005D*/
    IL_0085:  /* 06   |                  */ ldloc.0
    IL_0086:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_008b:  /* 2A   |                  */ ret

    IL_008c:  /* 02   |                  */ ldarg.0
    IL_008d:  /* 07   |                  */ ldloc.1
    IL_008e:  /* 8C   | (01)00005B       */ box        [mscorlib/*23000001*/]System.UInt64/*0100005B*/
    IL_0093:  /* 06   |                  */ ldloc.0
    IL_0094:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_0099:  /* 2A   |                  */ ret

    IL_009a:  /* 06   |                  */ ldloc.0
    IL_009b:  /* 12   | 02               */ ldloca.s   V_2
    IL_009d:  /* 28   | (0A)000086       */ call       bool [mscorlib/*23000001*/]System.Int64/*0100005D*/::TryParse(string,
                                                                                                                     int64&) /* 0A000086 */
    IL_00a2:  /* 2D   | 1B               */ brtrue.s   IL_00bf

    IL_00a4:  /* 02   |                  */ ldarg.0
    IL_00a5:  /* 72   | (70)000401       */ ldstr      "Invalid integer literal '{0}'" /* 70000401 */
    IL_00aa:  /* 17   |                  */ ldc.i4.1
    IL_00ab:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00b0:  /* 13   | 04               */ stloc.s    V_4
    IL_00b2:  /* 11   | 04               */ ldloc.s    V_4
    IL_00b4:  /* 16   |                  */ ldc.i4.0
    IL_00b5:  /* 06   |                  */ ldloc.0
    IL_00b6:  /* A2   |                  */ stelem.ref
    IL_00b7:  /* 11   | 04               */ ldloc.s    V_4
    IL_00b9:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_00be:  /* 7A   |                  */ throw

    IL_00bf:  /* 02   |                  */ ldarg.0
    IL_00c0:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_00c5:  /* 08   |                  */ ldloc.2
    IL_00c6:  /* 20   | 00000080         */ ldc.i4     0x80000000
    IL_00cb:  /* 6A   |                  */ conv.i8
    IL_00cc:  /* 32   | 18               */ blt.s      IL_00e6

    IL_00ce:  /* 08   |                  */ ldloc.2
    IL_00cf:  /* 20   | FFFFFF7F         */ ldc.i4     0x7fffffff
    IL_00d4:  /* 6A   |                  */ conv.i8
    IL_00d5:  /* 30   | 0F               */ bgt.s      IL_00e6

    IL_00d7:  /* 02   |                  */ ldarg.0
    IL_00d8:  /* 08   |                  */ ldloc.2
    IL_00d9:  /* 69   |                  */ conv.i4
    IL_00da:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_00df:  /* 06   |                  */ ldloc.0
    IL_00e0:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_00e5:  /* 2A   |                  */ ret

    IL_00e6:  /* 02   |                  */ ldarg.0
    IL_00e7:  /* 08   |                  */ ldloc.2
    IL_00e8:  /* 8C   | (01)00005D       */ box        [mscorlib/*23000001*/]System.Int64/*0100005D*/
    IL_00ed:  /* 06   |                  */ ldloc.0
    IL_00ee:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_00f3:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseIntegerLiteral

  .method /*06000036*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseRealLiteral() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x395c
    // Code size       142 (0x8e)
    .maxstack  5
    .locals /*1100001E*/ init (string V_0,
             object V_1,
             char V_2,
             float32 V_3,
             float64 V_4,
             object[] V_5)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 1B   |                  */ ldc.i4.5
    IL_0002:  /* 28   | (06)000073       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/) /* 06000073 */
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_000d:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0012:  /* 0A   |                  */ stloc.0
    IL_0013:  /* 14   |                  */ ldnull
    IL_0014:  /* 0B   |                  */ stloc.1
    IL_0015:  /* 06   |                  */ ldloc.0
    IL_0016:  /* 06   |                  */ ldloc.0
    IL_0017:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_001c:  /* 17   |                  */ ldc.i4.1
    IL_001d:  /* 59   |                  */ sub
    IL_001e:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_0023:  /* 0C   |                  */ stloc.2
    IL_0024:  /* 08   |                  */ ldloc.2
    IL_0025:  /* 1F   | 46               */ ldc.i4.s   70
    IL_0027:  /* 2E   | 05               */ beq.s      IL_002e

    IL_0029:  /* 08   |                  */ ldloc.2
    IL_002a:  /* 1F   | 66               */ ldc.i4.s   102
    IL_002c:  /* 33   | 21               */ bne.un.s   IL_004f

    IL_002e:  /* 06   |                  */ ldloc.0
    IL_002f:  /* 16   |                  */ ldc.i4.0
    IL_0030:  /* 06   |                  */ ldloc.0
    IL_0031:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_0036:  /* 17   |                  */ ldc.i4.1
    IL_0037:  /* 59   |                  */ sub
    IL_0038:  /* 6F   | (0A)000082       */ callvirt   instance string [mscorlib/*23000001*/]System.String/*01000042*/::Substring(int32,
                                                                                                                                  int32) /* 0A000082 */
    IL_003d:  /* 12   | 03               */ ldloca.s   V_3
    IL_003f:  /* 28   | (0A)000087       */ call       bool [mscorlib/*23000001*/]System.Single/*0100005E*/::TryParse(string,
                                                                                                                      float32&) /* 0A000087 */
    IL_0044:  /* 2C   | 1B               */ brfalse.s  IL_0061

    IL_0046:  /* 09   |                  */ ldloc.3
    IL_0047:  /* 8C   | (01)00005E       */ box        [mscorlib/*23000001*/]System.Single/*0100005E*/
    IL_004c:  /* 0B   |                  */ stloc.1
    IL_004d:  /* 2B   | 12               */ br.s       IL_0061

    IL_004f:  /* 06   |                  */ ldloc.0
    IL_0050:  /* 12   | 04               */ ldloca.s   V_4
    IL_0052:  /* 28   | (0A)000088       */ call       bool [mscorlib/*23000001*/]System.Double/*0100005F*/::TryParse(string,
                                                                                                                      float64&) /* 0A000088 */
    IL_0057:  /* 2C   | 08               */ brfalse.s  IL_0061

    IL_0059:  /* 11   | 04               */ ldloc.s    V_4
    IL_005b:  /* 8C   | (01)00005F       */ box        [mscorlib/*23000001*/]System.Double/*0100005F*/
    IL_0060:  /* 0B   |                  */ stloc.1
    IL_0061:  /* 07   |                  */ ldloc.1
    IL_0062:  /* 2D   | 1B               */ brtrue.s   IL_007f

    IL_0064:  /* 02   |                  */ ldarg.0
    IL_0065:  /* 72   | (70)00043D       */ ldstr      "Invalid real literal '{0}'" /* 7000043D */
    IL_006a:  /* 17   |                  */ ldc.i4.1
    IL_006b:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0070:  /* 13   | 05               */ stloc.s    V_5
    IL_0072:  /* 11   | 05               */ ldloc.s    V_5
    IL_0074:  /* 16   |                  */ ldc.i4.0
    IL_0075:  /* 06   |                  */ ldloc.0
    IL_0076:  /* A2   |                  */ stelem.ref
    IL_0077:  /* 11   | 05               */ ldloc.s    V_5
    IL_0079:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_007e:  /* 7A   |                  */ throw

    IL_007f:  /* 02   |                  */ ldarg.0
    IL_0080:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0085:  /* 02   |                  */ ldarg.0
    IL_0086:  /* 07   |                  */ ldloc.1
    IL_0087:  /* 06   |                  */ ldloc.0
    IL_0088:  /* 28   | (06)000037       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::CreateLiteral(object,
                                                                                                                                                                                                              string) /* 06000037 */
    IL_008d:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseRealLiteral

  .method /*06000037*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          CreateLiteral(object 'value',
                        string text) cil managed
  // SIG: 20 02 12 25 1C 0E
  {
    // Method begins at RVA 0x39f8
    // Code size       22 (0x16)
    .maxstack  3
    .locals /*1100001F*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ V_0)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7B   | (04)000017       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string> System.Linq.Dynamic.ExpressionParser/*0200000A*/::literals /* 04000017 */
    IL_000d:  /* 06   |                  */ ldloc.0
    IL_000e:  /* 04   |                  */ ldarg.2
    IL_000f:  /* 6F   | (0A)000089       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string>/*1B00000C*/::Add(!0,
                                                                                                                                                                                                                                                            !1) /* 0A000089 */
    IL_0014:  /* 06   |                  */ ldloc.0
    IL_0015:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::CreateLiteral

  .method /*06000038*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseParenExpression() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3a1c
    // Code size       47 (0x2f)
    .maxstack  3
    .locals /*1100001A*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0003:  /* 72   | (70)000473       */ ldstr      "'(' expected" /* 70000473 */
    IL_0008:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_000d:  /* 02   |                  */ ldarg.0
    IL_000e:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_0019:  /* 0A   |                  */ stloc.0
    IL_001a:  /* 02   |                  */ ldarg.0
    IL_001b:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_001d:  /* 72   | (70)00048D       */ ldstr      "')' or operator expected" /* 7000048D */
    IL_0022:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0027:  /* 02   |                  */ ldarg.0
    IL_0028:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_002d:  /* 06   |                  */ ldloc.0
    IL_002e:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseParenExpression

  .method /*06000039*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseIdentifier() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3a58
    // Code size       272 (0x110)
    .maxstack  5
    .locals /*11000020*/ init (object V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ V_2,
             object[] V_3)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 18   |                  */ ldc.i4.2
    IL_0002:  /* 28   | (06)000073       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/) /* 06000073 */
    IL_0007:  /* 7E   | (04)000014       */ ldsfld     class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywords /* 04000014 */
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0012:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0017:  /* 12   | 00               */ ldloca.s   V_0
    IL_0019:  /* 6F   | (0A)00008A       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::TryGetValue(!0,
                                                                                                                                                                                             !1&) /* 0A00008A */
    IL_001e:  /* 2C   | 4F               */ brfalse.s  IL_006f

    IL_0020:  /* 06   |                  */ ldloc.0
    IL_0021:  /* 75   | (01)000008       */ isinst     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0026:  /* 2C   | 0D               */ brfalse.s  IL_0035

    IL_0028:  /* 02   |                  */ ldarg.0
    IL_0029:  /* 06   |                  */ ldloc.0
    IL_002a:  /* 74   | (01)000008       */ castclass  [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_002f:  /* 28   | (06)00003F       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseTypeAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600003F */
    IL_0034:  /* 2A   |                  */ ret

    IL_0035:  /* 06   |                  */ ldloc.0
    IL_0036:  /* 7E   | (04)000011       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIt /* 04000011 */
    IL_003b:  /* 33   | 07               */ bne.un.s   IL_0044

    IL_003d:  /* 02   |                  */ ldarg.0
    IL_003e:  /* 28   | (06)00003A       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseIt() /* 0600003A */
    IL_0043:  /* 2A   |                  */ ret

    IL_0044:  /* 06   |                  */ ldloc.0
    IL_0045:  /* 7E   | (04)000012       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIif /* 04000012 */
    IL_004a:  /* 33   | 07               */ bne.un.s   IL_0053

    IL_004c:  /* 02   |                  */ ldarg.0
    IL_004d:  /* 28   | (06)00003B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseIif() /* 0600003B */
    IL_0052:  /* 2A   |                  */ ret

    IL_0053:  /* 06   |                  */ ldloc.0
    IL_0054:  /* 7E   | (04)000013       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordNew /* 04000013 */
    IL_0059:  /* 33   | 07               */ bne.un.s   IL_0062

    IL_005b:  /* 02   |                  */ ldarg.0
    IL_005c:  /* 28   | (06)00003D       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseNew() /* 0600003D */
    IL_0061:  /* 2A   |                  */ ret

    IL_0062:  /* 02   |                  */ ldarg.0
    IL_0063:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0068:  /* 06   |                  */ ldloc.0
    IL_0069:  /* 74   | (01)000009       */ castclass  [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_006e:  /* 2A   |                  */ ret

    IL_006f:  /* 02   |                  */ ldarg.0
    IL_0070:  /* 7B   | (04)000015       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::symbols /* 04000015 */
    IL_0075:  /* 02   |                  */ ldarg.0
    IL_0076:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_007b:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0080:  /* 12   | 00               */ ldloca.s   V_0
    IL_0082:  /* 6F   | (0A)00008A       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::TryGetValue(!0,
                                                                                                                                                                                             !1&) /* 0A00008A */
    IL_0087:  /* 2D   | 22               */ brtrue.s   IL_00ab

    IL_0089:  /* 02   |                  */ ldarg.0
    IL_008a:  /* 7B   | (04)000016       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::externals /* 04000016 */
    IL_008f:  /* 2C   | 47               */ brfalse.s  IL_00d8

    IL_0091:  /* 02   |                  */ ldarg.0
    IL_0092:  /* 7B   | (04)000016       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object> System.Linq.Dynamic.ExpressionParser/*0200000A*/::externals /* 04000016 */
    IL_0097:  /* 02   |                  */ ldarg.0
    IL_0098:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_009d:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_00a2:  /* 12   | 00               */ ldloca.s   V_0
    IL_00a4:  /* 6F   | (0A)00008B       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.IDictionary`2/*01000014*/<string,object>/*1B00000D*/::TryGetValue(!0,
                                                                                                                                                                                              !1&) /* 0A00008B */
    IL_00a9:  /* 2C   | 2D               */ brfalse.s  IL_00d8

    IL_00ab:  /* 06   |                  */ ldloc.0
    IL_00ac:  /* 75   | (01)000009       */ isinst     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_00b1:  /* 0B   |                  */ stloc.1
    IL_00b2:  /* 07   |                  */ ldloc.1
    IL_00b3:  /* 2D   | 09               */ brtrue.s   IL_00be

    IL_00b5:  /* 06   |                  */ ldloc.0
    IL_00b6:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_00bb:  /* 0B   |                  */ stloc.1
    IL_00bc:  /* 2B   | 12               */ br.s       IL_00d0

    IL_00be:  /* 07   |                  */ ldloc.1
    IL_00bf:  /* 75   | (01)00000A       */ isinst     [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/
    IL_00c4:  /* 0C   |                  */ stloc.2
    IL_00c5:  /* 08   |                  */ ldloc.2
    IL_00c6:  /* 2C   | 08               */ brfalse.s  IL_00d0

    IL_00c8:  /* 02   |                  */ ldarg.0
    IL_00c9:  /* 08   |                  */ ldloc.2
    IL_00ca:  /* 28   | (06)00003E       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseLambdaInvocation(class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/) /* 0600003E */
    IL_00cf:  /* 2A   |                  */ ret

    IL_00d0:  /* 02   |                  */ ldarg.0
    IL_00d1:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_00d6:  /* 07   |                  */ ldloc.1
    IL_00d7:  /* 2A   |                  */ ret

    IL_00d8:  /* 02   |                  */ ldarg.0
    IL_00d9:  /* 7B   | (04)000018       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_00de:  /* 2C   | 0E               */ brfalse.s  IL_00ee

    IL_00e0:  /* 02   |                  */ ldarg.0
    IL_00e1:  /* 14   |                  */ ldnull
    IL_00e2:  /* 02   |                  */ ldarg.0
    IL_00e3:  /* 7B   | (04)000018       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_00e8:  /* 28   | (06)000041       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseMemberAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000041 */
    IL_00ed:  /* 2A   |                  */ ret

    IL_00ee:  /* 02   |                  */ ldarg.0
    IL_00ef:  /* 72   | (70)0004BF       */ ldstr      "Unknown identifier '{0}'" /* 700004BF */
    IL_00f4:  /* 17   |                  */ ldc.i4.1
    IL_00f5:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00fa:  /* 0D   |                  */ stloc.3
    IL_00fb:  /* 09   |                  */ ldloc.3
    IL_00fc:  /* 16   |                  */ ldc.i4.0
    IL_00fd:  /* 02   |                  */ ldarg.0
    IL_00fe:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0103:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0108:  /* A2   |                  */ stelem.ref
    IL_0109:  /* 09   |                  */ ldloc.3
    IL_010a:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_010f:  /* 7A   |                  */ throw
  } // end of method ExpressionParser::ParseIdentifier

  .method /*0600003A*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseIt() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3b74
    // Code size       39 (0x27)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000018       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_0006:  /* 2D   | 12               */ brtrue.s   IL_001a

    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 72   | (70)0004F1       */ ldstr      "No 'it' is in scope" /* 700004F1 */
    IL_000e:  /* 16   |                  */ ldc.i4.0
    IL_000f:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0014:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_0019:  /* 7A   |                  */ throw

    IL_001a:  /* 02   |                  */ ldarg.0
    IL_001b:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0020:  /* 02   |                  */ ldarg.0
    IL_0021:  /* 7B   | (04)000018       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_0026:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseIt

  .method /*0600003B*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseIif() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3b9c
    // Code size       67 (0x43)
    .maxstack  5
    .locals /*11000021*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 28   | (06)000044       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArgumentList() /* 06000044 */
    IL_0018:  /* 0B   |                  */ stloc.1
    IL_0019:  /* 07   |                  */ ldloc.1
    IL_001a:  /* 8E   |                  */ ldlen
    IL_001b:  /* 69   |                  */ conv.i4
    IL_001c:  /* 19   |                  */ ldc.i4.3
    IL_001d:  /* 2E   | 13               */ beq.s      IL_0032

    IL_001f:  /* 02   |                  */ ldarg.0
    IL_0020:  /* 06   |                  */ ldloc.0
    IL_0021:  /* 72   | (70)000519       */ ldstr      "The 'iif' function requires three arguments" /* 70000519 */
    IL_0026:  /* 16   |                  */ ldc.i4.0
    IL_0027:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_002c:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0031:  /* 7A   |                  */ throw

    IL_0032:  /* 02   |                  */ ldarg.0
    IL_0033:  /* 07   |                  */ ldloc.1
    IL_0034:  /* 16   |                  */ ldc.i4.0
    IL_0035:  /* 9A   |                  */ ldelem.ref
    IL_0036:  /* 07   |                  */ ldloc.1
    IL_0037:  /* 17   |                  */ ldc.i4.1
    IL_0038:  /* 9A   |                  */ ldelem.ref
    IL_0039:  /* 07   |                  */ ldloc.1
    IL_003a:  /* 18   |                  */ ldc.i4.2
    IL_003b:  /* 9A   |                  */ ldelem.ref
    IL_003c:  /* 06   |                  */ ldloc.0
    IL_003d:  /* 28   | (06)00003C       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateConditional(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                    int32) /* 0600003C */
    IL_0042:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseIif

  .method /*0600003C*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateConditional(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ test,
                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ expr1,
                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ expr2,
                              int32 errorPos) cil managed
  // SIG: 20 04 12 25 12 25 12 25 12 25 08
  {
    // Method begins at RVA 0x3bec
    // Code size       282 (0x11a)
    .maxstack  6
    .locals /*11000022*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_1,
             string V_2,
             string V_3,
             object[] V_4,
             object[] V_5)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000033       */ ldtoken    [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0015:  /* 2C   | 14               */ brfalse.s  IL_002b

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 0E   | 04               */ ldarg.s    errorPos
    IL_001a:  /* 72   | (70)000571       */ ldstr      "The first expression must be of type 'Boolean'" /* 70000571 */
    IL_001f:  /* 16   |                  */ ldc.i4.0
    IL_0020:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0025:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_002a:  /* 7A   |                  */ throw

    IL_002b:  /* 04   |                  */ ldarg.2
    IL_002c:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0031:  /* 05   |                  */ ldarg.3
    IL_0032:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0037:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_003c:  /* 39   | D0000000         */ brfalse    IL_0111

    IL_0041:  /* 05   |                  */ ldarg.3
    IL_0042:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0047:  /* 33   | 03               */ bne.un.s   IL_004c

    IL_0049:  /* 14   |                  */ ldnull
    IL_004a:  /* 2B   | 0E               */ br.s       IL_005a

    IL_004c:  /* 02   |                  */ ldarg.0
    IL_004d:  /* 04   |                  */ ldarg.2
    IL_004e:  /* 05   |                  */ ldarg.3
    IL_004f:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0054:  /* 17   |                  */ ldc.i4.1
    IL_0055:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_005a:  /* 0A   |                  */ stloc.0
    IL_005b:  /* 04   |                  */ ldarg.2
    IL_005c:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0061:  /* 33   | 03               */ bne.un.s   IL_0066

    IL_0063:  /* 14   |                  */ ldnull
    IL_0064:  /* 2B   | 0E               */ br.s       IL_0074

    IL_0066:  /* 02   |                  */ ldarg.0
    IL_0067:  /* 05   |                  */ ldarg.3
    IL_0068:  /* 04   |                  */ ldarg.2
    IL_0069:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_006e:  /* 17   |                  */ ldc.i4.1
    IL_006f:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_0074:  /* 0B   |                  */ stloc.1
    IL_0075:  /* 06   |                  */ ldloc.0
    IL_0076:  /* 2C   | 0B               */ brfalse.s  IL_0083

    IL_0078:  /* 07   |                  */ ldloc.1
    IL_0079:  /* 2D   | 08               */ brtrue.s   IL_0083

    IL_007b:  /* 06   |                  */ ldloc.0
    IL_007c:  /* 10   | 02               */ starg.s    expr1
    IL_007e:  /* 38   | 8E000000         */ br         IL_0111

    IL_0083:  /* 07   |                  */ ldloc.1
    IL_0084:  /* 2C   | 0B               */ brfalse.s  IL_0091

    IL_0086:  /* 06   |                  */ ldloc.0
    IL_0087:  /* 2D   | 08               */ brtrue.s   IL_0091

    IL_0089:  /* 07   |                  */ ldloc.1
    IL_008a:  /* 10   | 03               */ starg.s    expr2
    IL_008c:  /* 38   | 80000000         */ br         IL_0111

    IL_0091:  /* 04   |                  */ ldarg.2
    IL_0092:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0097:  /* 33   | 07               */ bne.un.s   IL_00a0

    IL_0099:  /* 72   | (70)0005CF       */ ldstr      "null" /* 700005CF */
    IL_009e:  /* 2B   | 0B               */ br.s       IL_00ab

    IL_00a0:  /* 04   |                  */ ldarg.2
    IL_00a1:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00a6:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_00ab:  /* 0C   |                  */ stloc.2
    IL_00ac:  /* 05   |                  */ ldarg.3
    IL_00ad:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_00b2:  /* 33   | 07               */ bne.un.s   IL_00bb

    IL_00b4:  /* 72   | (70)0005CF       */ ldstr      "null" /* 700005CF */
    IL_00b9:  /* 2B   | 0B               */ br.s       IL_00c6

    IL_00bb:  /* 05   |                  */ ldarg.3
    IL_00bc:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00c1:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_00c6:  /* 0D   |                  */ stloc.3
    IL_00c7:  /* 06   |                  */ ldloc.0
    IL_00c8:  /* 2C   | 25               */ brfalse.s  IL_00ef

    IL_00ca:  /* 07   |                  */ ldloc.1
    IL_00cb:  /* 2C   | 22               */ brfalse.s  IL_00ef

    IL_00cd:  /* 02   |                  */ ldarg.0
    IL_00ce:  /* 0E   | 04               */ ldarg.s    errorPos
    IL_00d0:  /* 72   | (70)0005D9       */ ldstr      "Both of the types '{0}' and '{1}' convert to the o"
    + "ther" /* 700005D9 */
    IL_00d5:  /* 18   |                  */ ldc.i4.2
    IL_00d6:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00db:  /* 13   | 04               */ stloc.s    V_4
    IL_00dd:  /* 11   | 04               */ ldloc.s    V_4
    IL_00df:  /* 16   |                  */ ldc.i4.0
    IL_00e0:  /* 08   |                  */ ldloc.2
    IL_00e1:  /* A2   |                  */ stelem.ref
    IL_00e2:  /* 11   | 04               */ ldloc.s    V_4
    IL_00e4:  /* 17   |                  */ ldc.i4.1
    IL_00e5:  /* 09   |                  */ ldloc.3
    IL_00e6:  /* A2   |                  */ stelem.ref
    IL_00e7:  /* 11   | 04               */ ldloc.s    V_4
    IL_00e9:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_00ee:  /* 7A   |                  */ throw

    IL_00ef:  /* 02   |                  */ ldarg.0
    IL_00f0:  /* 0E   | 04               */ ldarg.s    errorPos
    IL_00f2:  /* 72   | (70)000647       */ ldstr      "Neither of the types '{0}' and '{1}' converts to t"
    + "he other" /* 70000647 */
    IL_00f7:  /* 18   |                  */ ldc.i4.2
    IL_00f8:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00fd:  /* 13   | 05               */ stloc.s    V_5
    IL_00ff:  /* 11   | 05               */ ldloc.s    V_5
    IL_0101:  /* 16   |                  */ ldc.i4.0
    IL_0102:  /* 08   |                  */ ldloc.2
    IL_0103:  /* A2   |                  */ stelem.ref
    IL_0104:  /* 11   | 05               */ ldloc.s    V_5
    IL_0106:  /* 17   |                  */ ldc.i4.1
    IL_0107:  /* 09   |                  */ ldloc.3
    IL_0108:  /* A2   |                  */ stelem.ref
    IL_0109:  /* 11   | 05               */ ldloc.s    V_5
    IL_010b:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0110:  /* 7A   |                  */ throw

    IL_0111:  /* 03   |                  */ ldarg.1
    IL_0112:  /* 04   |                  */ ldarg.2
    IL_0113:  /* 05   |                  */ ldarg.3
    IL_0114:  /* 28   | (0A)00008C       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConditionalExpression/*01000060*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Condition(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A00008C */
    IL_0119:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateConditional

  .method /*0600003D*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseNew() cil managed
  // SIG: 20 00 12 25
  {
    // Method begins at RVA 0x3d14
    // Code size       300 (0x12c)
    .maxstack  5
    .locals /*11000023*/ init (class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/> V_0,
             class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/> V_1,
             int32 V_2,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_3,
             string V_4,
             class [System.Core/*23000002*/]System.Linq.Expressions.MemberExpression/*01000061*/ V_5,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_6,
             class [System.Core/*23000002*/]System.Linq.Expressions.MemberBinding/*01000062*/[] V_7,
             int32 V_8)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0006:  /* 02   |                  */ ldarg.0
    IL_0007:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0009:  /* 72   | (70)000473       */ ldstr      "'(' expected" /* 70000473 */
    IL_000e:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0019:  /* 73   | (0A)00008D       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B00000F*/::.ctor() /* 0A00008D */
    IL_001e:  /* 0A   |                  */ stloc.0
    IL_001f:  /* 73   | (0A)00008E       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::.ctor() /* 0A00008E */
    IL_0024:  /* 0B   |                  */ stloc.1
    IL_0025:  /* 02   |                  */ ldarg.0
    IL_0026:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_002b:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0030:  /* 0C   |                  */ stloc.2
    IL_0031:  /* 02   |                  */ ldarg.0
    IL_0032:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_0037:  /* 0D   |                  */ stloc.3
    IL_0038:  /* 02   |                  */ ldarg.0
    IL_0039:  /* 72   | (70)0006BD       */ ldstr      "as" /* 700006BD */
    IL_003e:  /* 28   | (06)00006F       */ call       instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::TokenIdentifierIs(string) /* 0600006F */
    IL_0043:  /* 2C   | 16               */ brfalse.s  IL_005b

    IL_0045:  /* 02   |                  */ ldarg.0
    IL_0046:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_004b:  /* 02   |                  */ ldarg.0
    IL_004c:  /* 28   | (06)000070       */ call       instance string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetIdentifier() /* 06000070 */
    IL_0051:  /* 13   | 04               */ stloc.s    V_4
    IL_0053:  /* 02   |                  */ ldarg.0
    IL_0054:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0059:  /* 2B   | 2D               */ br.s       IL_0088

    IL_005b:  /* 09   |                  */ ldloc.3
    IL_005c:  /* 75   | (01)000061       */ isinst     [System.Core/*23000002*/]System.Linq.Expressions.MemberExpression/*01000061*/
    IL_0061:  /* 13   | 05               */ stloc.s    V_5
    IL_0063:  /* 11   | 05               */ ldloc.s    V_5
    IL_0065:  /* 2D   | 13               */ brtrue.s   IL_007a

    IL_0067:  /* 02   |                  */ ldarg.0
    IL_0068:  /* 08   |                  */ ldloc.2
    IL_0069:  /* 72   | (70)0006C3       */ ldstr      "Expression is missing an 'as' clause" /* 700006C3 */
    IL_006e:  /* 16   |                  */ ldc.i4.0
    IL_006f:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0074:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0079:  /* 7A   |                  */ throw

    IL_007a:  /* 11   | 05               */ ldloc.s    V_5
    IL_007c:  /* 6F   | (0A)00008F       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/ [System.Core/*23000002*/]System.Linq.Expressions.MemberExpression/*01000061*/::get_Member() /* 0A00008F */
    IL_0081:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_0086:  /* 13   | 04               */ stloc.s    V_4
    IL_0088:  /* 07   |                  */ ldloc.1
    IL_0089:  /* 09   |                  */ ldloc.3
    IL_008a:  /* 6F   | (0A)000090       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::Add(!0) /* 0A000090 */
    IL_008f:  /* 06   |                  */ ldloc.0
    IL_0090:  /* 11   | 04               */ ldloc.s    V_4
    IL_0092:  /* 09   |                  */ ldloc.3
    IL_0093:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0098:  /* 73   | (06)00000D       */ newobj     instance void System.Linq.Dynamic.DynamicProperty/*02000004*/::.ctor(string,
                                                                                                                            class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600000D */
    IL_009d:  /* 6F   | (0A)000091       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B00000F*/::Add(!0) /* 0A000091 */
    IL_00a2:  /* 02   |                  */ ldarg.0
    IL_00a3:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_00a8:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_00ad:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_00af:  /* 33   | 0B               */ bne.un.s   IL_00bc

    IL_00b1:  /* 02   |                  */ ldarg.0
    IL_00b2:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_00b7:  /* 38   | 69FFFFFF         */ br         IL_0025

    IL_00bc:  /* 02   |                  */ ldarg.0
    IL_00bd:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_00bf:  /* 72   | (70)00070D       */ ldstr      "')' or ',' expected" /* 7000070D */
    IL_00c4:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_00c9:  /* 02   |                  */ ldarg.0
    IL_00ca:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_00cf:  /* 06   |                  */ ldloc.0
    IL_00d0:  /* 28   | (06)000015       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.DynamicExpression/*02000005*/::CreateClass(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>) /* 06000015 */
    IL_00d5:  /* 13   | 06               */ stloc.s    V_6
    IL_00d7:  /* 06   |                  */ ldloc.0
    IL_00d8:  /* 6F   | (0A)000092       */ callvirt   instance int32 class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B00000F*/::get_Count() /* 0A000092 */
    IL_00dd:  /* 8D   | (01)000062       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.MemberBinding/*01000062*/
    IL_00e2:  /* 13   | 07               */ stloc.s    V_7
    IL_00e4:  /* 16   |                  */ ldc.i4.0
    IL_00e5:  /* 13   | 08               */ stloc.s    V_8
    IL_00e7:  /* 2B   | 2C               */ br.s       IL_0115

    IL_00e9:  /* 11   | 07               */ ldloc.s    V_7
    IL_00eb:  /* 11   | 08               */ ldloc.s    V_8
    IL_00ed:  /* 11   | 06               */ ldloc.s    V_6
    IL_00ef:  /* 06   |                  */ ldloc.0
    IL_00f0:  /* 11   | 08               */ ldloc.s    V_8
    IL_00f2:  /* 6F   | (0A)000093       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class System.Linq.Dynamic.DynamicProperty/*02000004*/>/*1B00000F*/::get_Item(int32) /* 0A000093 */
    IL_00f7:  /* 6F   | (06)00000E       */ callvirt   instance string System.Linq.Dynamic.DynamicProperty/*02000004*/::get_Name() /* 0600000E */
    IL_00fc:  /* 6F   | (0A)000094       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetProperty(string) /* 0A000094 */
    IL_0101:  /* 07   |                  */ ldloc.1
    IL_0102:  /* 11   | 08               */ ldloc.s    V_8
    IL_0104:  /* 6F   | (0A)000095       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::get_Item(int32) /* 0A000095 */
    IL_0109:  /* 28   | (0A)000096       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MemberAssignment/*01000063*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Bind(class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A000096 */
    IL_010e:  /* A2   |                  */ stelem.ref
    IL_010f:  /* 11   | 08               */ ldloc.s    V_8
    IL_0111:  /* 17   |                  */ ldc.i4.1
    IL_0112:  /* 58   |                  */ add
    IL_0113:  /* 13   | 08               */ stloc.s    V_8
    IL_0115:  /* 11   | 08               */ ldloc.s    V_8
    IL_0117:  /* 11   | 07               */ ldloc.s    V_7
    IL_0119:  /* 8E   |                  */ ldlen
    IL_011a:  /* 69   |                  */ conv.i4
    IL_011b:  /* 32   | CC               */ blt.s      IL_00e9

    IL_011d:  /* 11   | 06               */ ldloc.s    V_6
    IL_011f:  /* 28   | (0A)000097       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.NewExpression/*01000064*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::New(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000097 */
    IL_0124:  /* 11   | 07               */ ldloc.s    V_7
    IL_0126:  /* 28   | (0A)000098       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MemberInitExpression/*01000065*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::MemberInit(class [System.Core/*23000002*/]System.Linq.Expressions.NewExpression/*01000064*/,
                                                                                                                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.MemberBinding/*01000062*/[]) /* 0A000098 */
    IL_012b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseNew

  .method /*0600003E*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseLambdaInvocation(class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ lambda) cil managed
  // SIG: 20 01 12 25 12 29
  {
    // Method begins at RVA 0x3e4c
    // Code size       76 (0x4c)
    .maxstack  6
    .locals /*11000024*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 28   | (06)000044       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArgumentList() /* 06000044 */
    IL_0018:  /* 0B   |                  */ stloc.1
    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 03   |                  */ ldarg.1
    IL_001b:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0020:  /* 72   | (70)000735       */ ldstr      "Invoke" /* 70000735 */
    IL_0025:  /* 16   |                  */ ldc.i4.0
    IL_0026:  /* 07   |                  */ ldloc.1
    IL_0027:  /* 12   | 02               */ ldloca.s   V_2
    IL_0029:  /* 28   | (06)000054       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                   string,
                                                                                                                                   bool,
                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                   class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000054 */
    IL_002e:  /* 17   |                  */ ldc.i4.1
    IL_002f:  /* 2E   | 13               */ beq.s      IL_0044

    IL_0031:  /* 02   |                  */ ldarg.0
    IL_0032:  /* 06   |                  */ ldloc.0
    IL_0033:  /* 72   | (70)000743       */ ldstr      "Argument list incompatible with lambda expression" /* 70000743 */
    IL_0038:  /* 16   |                  */ ldc.i4.0
    IL_0039:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_003e:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0043:  /* 7A   |                  */ throw

    IL_0044:  /* 03   |                  */ ldarg.1
    IL_0045:  /* 07   |                  */ ldloc.1
    IL_0046:  /* 28   | (0A)000099       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.InvocationExpression/*01000066*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Invoke(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A000099 */
    IL_004b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseLambdaInvocation

  .method /*0600003F*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseTypeAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 20 01 12 25 12 21
  {
    // Method begins at RVA 0x3ea4
    // Code size       301 (0x12d)
    .maxstack  6
    .locals /*11000025*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_2,
             object[] V_3,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_4,
             int32 V_5,
             object[] V_6,
             object[] V_7)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0018:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_001d:  /* 1F   | 15               */ ldc.i4.s   21
    IL_001f:  /* 33   | 54               */ bne.un.s   IL_0075

    IL_0021:  /* 03   |                  */ ldarg.1
    IL_0022:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0027:  /* 2C   | 08               */ brfalse.s  IL_0031

    IL_0029:  /* 03   |                  */ ldarg.1
    IL_002a:  /* 28   | (06)000048       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000048 */
    IL_002f:  /* 2C   | 1E               */ brfalse.s  IL_004f

    IL_0031:  /* 02   |                  */ ldarg.0
    IL_0032:  /* 06   |                  */ ldloc.0
    IL_0033:  /* 72   | (70)0007A7       */ ldstr      "Type '{0}' has no nullable form" /* 700007A7 */
    IL_0038:  /* 17   |                  */ ldc.i4.1
    IL_0039:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_003e:  /* 0D   |                  */ stloc.3
    IL_003f:  /* 09   |                  */ ldloc.3
    IL_0040:  /* 16   |                  */ ldc.i4.0
    IL_0041:  /* 03   |                  */ ldarg.1
    IL_0042:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0047:  /* A2   |                  */ stelem.ref
    IL_0048:  /* 09   |                  */ ldloc.3
    IL_0049:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_004e:  /* 7A   |                  */ throw

    IL_004f:  /* D0   | (01)000019       */ ldtoken    [mscorlib/*23000001*/]System.Nullable`1/*01000019*/
    IL_0054:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0059:  /* 17   |                  */ ldc.i4.1
    IL_005a:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_005f:  /* 13   | 04               */ stloc.s    V_4
    IL_0061:  /* 11   | 04               */ ldloc.s    V_4
    IL_0063:  /* 16   |                  */ ldc.i4.0
    IL_0064:  /* 03   |                  */ ldarg.1
    IL_0065:  /* A2   |                  */ stelem.ref
    IL_0066:  /* 11   | 04               */ ldloc.s    V_4
    IL_0068:  /* 6F   | (0A)000060       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::MakeGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000060 */
    IL_006d:  /* 10   | 01               */ starg.s    'type'
    IL_006f:  /* 02   |                  */ ldarg.0
    IL_0070:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0075:  /* 02   |                  */ ldarg.0
    IL_0076:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_007b:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_0080:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0082:  /* 40   | 8A000000         */ bne.un     IL_0111

    IL_0087:  /* 02   |                  */ ldarg.0
    IL_0088:  /* 28   | (06)000044       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArgumentList() /* 06000044 */
    IL_008d:  /* 0B   |                  */ stloc.1
    IL_008e:  /* 02   |                  */ ldarg.0
    IL_008f:  /* 03   |                  */ ldarg.1
    IL_0090:  /* 6F   | (0A)00009A       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.ConstructorInfo/*01000067*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetConstructors() /* 0A00009A */
    IL_0095:  /* 07   |                  */ ldloc.1
    IL_0096:  /* 12   | 02               */ ldloca.s   V_2
    IL_0098:  /* 28   | (06)000059       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindBestMethod(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>,
                                                                                                                                       class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                       class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000059 */
    IL_009d:  /* 13   | 05               */ stloc.s    V_5
    IL_009f:  /* 11   | 05               */ ldloc.s    V_5
    IL_00a1:  /* 45   | 02000000         */ switch     ( 
              /*      | 02000000         */             IL_00b0,
              /*      | 35000000         */             IL_00e3)
    IL_00ae:  /* 2B   | 40               */ br.s       IL_00f0

    IL_00b0:  /* 07   |                  */ ldloc.1
    IL_00b1:  /* 8E   |                  */ ldlen
    IL_00b2:  /* 69   |                  */ conv.i4
    IL_00b3:  /* 17   |                  */ ldc.i4.1
    IL_00b4:  /* 33   | 0C               */ bne.un.s   IL_00c2

    IL_00b6:  /* 02   |                  */ ldarg.0
    IL_00b7:  /* 07   |                  */ ldloc.1
    IL_00b8:  /* 16   |                  */ ldc.i4.0
    IL_00b9:  /* 9A   |                  */ ldelem.ref
    IL_00ba:  /* 03   |                  */ ldarg.1
    IL_00bb:  /* 06   |                  */ ldloc.0
    IL_00bc:  /* 28   | (06)000040       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateConversion(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                   class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                   int32) /* 06000040 */
    IL_00c1:  /* 2A   |                  */ ret

    IL_00c2:  /* 02   |                  */ ldarg.0
    IL_00c3:  /* 06   |                  */ ldloc.0
    IL_00c4:  /* 72   | (70)0007E7       */ ldstr      "No matching constructor in type '{0}'" /* 700007E7 */
    IL_00c9:  /* 17   |                  */ ldc.i4.1
    IL_00ca:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00cf:  /* 13   | 06               */ stloc.s    V_6
    IL_00d1:  /* 11   | 06               */ ldloc.s    V_6
    IL_00d3:  /* 16   |                  */ ldc.i4.0
    IL_00d4:  /* 03   |                  */ ldarg.1
    IL_00d5:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_00da:  /* A2   |                  */ stelem.ref
    IL_00db:  /* 11   | 06               */ ldloc.s    V_6
    IL_00dd:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_00e2:  /* 7A   |                  */ throw

    IL_00e3:  /* 08   |                  */ ldloc.2
    IL_00e4:  /* 74   | (01)000067       */ castclass  [mscorlib/*23000001*/]System.Reflection.ConstructorInfo/*01000067*/
    IL_00e9:  /* 07   |                  */ ldloc.1
    IL_00ea:  /* 28   | (0A)00009B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.NewExpression/*01000064*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::New(class [mscorlib/*23000001*/]System.Reflection.ConstructorInfo/*01000067*/,
                                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00009B */
    IL_00ef:  /* 2A   |                  */ ret

    IL_00f0:  /* 02   |                  */ ldarg.0
    IL_00f1:  /* 06   |                  */ ldloc.0
    IL_00f2:  /* 72   | (70)000833       */ ldstr      "Ambiguous invocation of '{0}' constructor" /* 70000833 */
    IL_00f7:  /* 17   |                  */ ldc.i4.1
    IL_00f8:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00fd:  /* 13   | 07               */ stloc.s    V_7
    IL_00ff:  /* 11   | 07               */ ldloc.s    V_7
    IL_0101:  /* 16   |                  */ ldc.i4.0
    IL_0102:  /* 03   |                  */ ldarg.1
    IL_0103:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0108:  /* A2   |                  */ stelem.ref
    IL_0109:  /* 11   | 07               */ ldloc.s    V_7
    IL_010b:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0110:  /* 7A   |                  */ throw

    IL_0111:  /* 02   |                  */ ldarg.0
    IL_0112:  /* 1F   | 0F               */ ldc.i4.s   15
    IL_0114:  /* 72   | (70)000887       */ ldstr      "'.' or '(' expected" /* 70000887 */
    IL_0119:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_011e:  /* 02   |                  */ ldarg.0
    IL_011f:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0124:  /* 02   |                  */ ldarg.0
    IL_0125:  /* 03   |                  */ ldarg.1
    IL_0126:  /* 14   |                  */ ldnull
    IL_0127:  /* 28   | (06)000041       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseMemberAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 06000041 */
    IL_012c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseTypeAccess

  .method /*06000040*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateConversion(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ expr,
                             class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                             int32 errorPos) cil managed
  // SIG: 20 03 12 25 12 25 12 21 08
  {
    // Method begins at RVA 0x3fe0
    // Code size       198 (0xc6)
    .maxstack  6
    .locals /*11000026*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             object[] V_1)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 06   |                  */ ldloc.0
    IL_0008:  /* 04   |                  */ ldarg.2
    IL_0009:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_000e:  /* 2C   | 02               */ brfalse.s  IL_0012

    IL_0010:  /* 03   |                  */ ldarg.1
    IL_0011:  /* 2A   |                  */ ret

    IL_0012:  /* 06   |                  */ ldloc.0
    IL_0013:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0018:  /* 2C   | 5B               */ brfalse.s  IL_0075

    IL_001a:  /* 04   |                  */ ldarg.2
    IL_001b:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0020:  /* 2C   | 53               */ brfalse.s  IL_0075

    IL_0022:  /* 06   |                  */ ldloc.0
    IL_0023:  /* 28   | (06)000048       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000048 */
    IL_0028:  /* 2D   | 08               */ brtrue.s   IL_0032

    IL_002a:  /* 04   |                  */ ldarg.2
    IL_002b:  /* 28   | (06)000048       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000048 */
    IL_0030:  /* 2C   | 1B               */ brfalse.s  IL_004d

    IL_0032:  /* 06   |                  */ ldloc.0
    IL_0033:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0038:  /* 04   |                  */ ldarg.2
    IL_0039:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_003e:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0043:  /* 2C   | 08               */ brfalse.s  IL_004d

    IL_0045:  /* 03   |                  */ ldarg.1
    IL_0046:  /* 04   |                  */ ldarg.2
    IL_0047:  /* 28   | (0A)00007B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Convert(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007B */
    IL_004c:  /* 2A   |                  */ ret

    IL_004d:  /* 06   |                  */ ldloc.0
    IL_004e:  /* 28   | (06)00004B       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNumericType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004B */
    IL_0053:  /* 2D   | 08               */ brtrue.s   IL_005d

    IL_0055:  /* 06   |                  */ ldloc.0
    IL_0056:  /* 28   | (06)00004F       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsEnumType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004F */
    IL_005b:  /* 2C   | 08               */ brfalse.s  IL_0065

    IL_005d:  /* 04   |                  */ ldarg.2
    IL_005e:  /* 28   | (06)00004B       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNumericType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004B */
    IL_0063:  /* 2D   | 08               */ brtrue.s   IL_006d

    IL_0065:  /* 04   |                  */ ldarg.2
    IL_0066:  /* 28   | (06)00004F       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsEnumType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004F */
    IL_006b:  /* 2C   | 08               */ brfalse.s  IL_0075

    IL_006d:  /* 03   |                  */ ldarg.1
    IL_006e:  /* 04   |                  */ ldarg.2
    IL_006f:  /* 28   | (0A)00009C       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::ConvertChecked(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00009C */
    IL_0074:  /* 2A   |                  */ ret

    IL_0075:  /* 06   |                  */ ldloc.0
    IL_0076:  /* 04   |                  */ ldarg.2
    IL_0077:  /* 6F   | (0A)00007A       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::IsAssignableFrom(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007A */
    IL_007c:  /* 2D   | 19               */ brtrue.s   IL_0097

    IL_007e:  /* 04   |                  */ ldarg.2
    IL_007f:  /* 06   |                  */ ldloc.0
    IL_0080:  /* 6F   | (0A)00007A       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::IsAssignableFrom(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007A */
    IL_0085:  /* 2D   | 10               */ brtrue.s   IL_0097

    IL_0087:  /* 06   |                  */ ldloc.0
    IL_0088:  /* 6F   | (0A)00009D       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsInterface() /* 0A00009D */
    IL_008d:  /* 2D   | 08               */ brtrue.s   IL_0097

    IL_008f:  /* 04   |                  */ ldarg.2
    IL_0090:  /* 6F   | (0A)00009D       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsInterface() /* 0A00009D */
    IL_0095:  /* 2C   | 08               */ brfalse.s  IL_009f

    IL_0097:  /* 03   |                  */ ldarg.1
    IL_0098:  /* 04   |                  */ ldarg.2
    IL_0099:  /* 28   | (0A)00007B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Convert(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007B */
    IL_009e:  /* 2A   |                  */ ret

    IL_009f:  /* 02   |                  */ ldarg.0
    IL_00a0:  /* 05   |                  */ ldarg.3
    IL_00a1:  /* 72   | (70)0008AF       */ ldstr      "A value of type '{0}' cannot be converted to type "
    + "'{1}'" /* 700008AF */
    IL_00a6:  /* 18   |                  */ ldc.i4.2
    IL_00a7:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00ac:  /* 0B   |                  */ stloc.1
    IL_00ad:  /* 07   |                  */ ldloc.1
    IL_00ae:  /* 16   |                  */ ldc.i4.0
    IL_00af:  /* 06   |                  */ ldloc.0
    IL_00b0:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_00b5:  /* A2   |                  */ stelem.ref
    IL_00b6:  /* 07   |                  */ ldloc.1
    IL_00b7:  /* 17   |                  */ ldc.i4.1
    IL_00b8:  /* 04   |                  */ ldarg.2
    IL_00b9:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_00be:  /* A2   |                  */ stelem.ref
    IL_00bf:  /* 07   |                  */ ldloc.1
    IL_00c0:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_00c5:  /* 7A   |                  */ throw
  } // end of method ExpressionParser::GenerateConversion

  .method /*06000041*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseMemberAccess(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                            class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 'instance') cil managed
  // SIG: 20 02 12 25 12 21 12 25
  {
    // Method begins at RVA 0x40b4
    // Code size       483 (0x1e3)
    .maxstack  6
    .locals /*11000027*/ init (int32 V_0,
             string V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_2,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_3,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_4,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_5,
             class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ V_6,
             class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/ V_7,
             int32 V_8,
             object[] V_9,
             object[] V_10,
             object[] V_11,
             object[] V_12,
             object[] V_13)
    IL_0000:  /* 04   |                  */ ldarg.2
    IL_0001:  /* 2C   | 08               */ brfalse.s  IL_000b

    IL_0003:  /* 04   |                  */ ldarg.2
    IL_0004:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0009:  /* 10   | 01               */ starg.s    'type'
    IL_000b:  /* 02   |                  */ ldarg.0
    IL_000c:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0011:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0016:  /* 0A   |                  */ stloc.0
    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 28   | (06)000070       */ call       instance string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetIdentifier() /* 06000070 */
    IL_001d:  /* 0B   |                  */ stloc.1
    IL_001e:  /* 02   |                  */ ldarg.0
    IL_001f:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0024:  /* 02   |                  */ ldarg.0
    IL_0025:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_002a:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_002f:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0031:  /* 40   | 4A010000         */ bne.un     IL_0180

    IL_0036:  /* 04   |                  */ ldarg.2
    IL_0037:  /* 2C   | 40               */ brfalse.s  IL_0079

    IL_0039:  /* 03   |                  */ ldarg.1
    IL_003a:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_003f:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0044:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0049:  /* 2C   | 2E               */ brfalse.s  IL_0079

    IL_004b:  /* D0   | (01)00000E       */ ldtoken    [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/
    IL_0050:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0055:  /* 03   |                  */ ldarg.1
    IL_0056:  /* 28   | (06)000042       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000042 */
    IL_005b:  /* 0C   |                  */ stloc.2
    IL_005c:  /* 08   |                  */ ldloc.2
    IL_005d:  /* 14   |                  */ ldnull
    IL_005e:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0063:  /* 2C   | 14               */ brfalse.s  IL_0079

    IL_0065:  /* 08   |                  */ ldloc.2
    IL_0066:  /* 6F   | (0A)00009E       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetGenericArguments() /* 0A00009E */
    IL_006b:  /* 16   |                  */ ldc.i4.0
    IL_006c:  /* 9A   |                  */ ldelem.ref
    IL_006d:  /* 0D   |                  */ stloc.3
    IL_006e:  /* 02   |                  */ ldarg.0
    IL_006f:  /* 04   |                  */ ldarg.2
    IL_0070:  /* 09   |                  */ ldloc.3
    IL_0071:  /* 07   |                  */ ldloc.1
    IL_0072:  /* 06   |                  */ ldloc.0
    IL_0073:  /* 28   | (06)000043       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseAggregate(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                               string,
                                                                                                                                                                                                               int32) /* 06000043 */
    IL_0078:  /* 2A   |                  */ ret

    IL_0079:  /* 02   |                  */ ldarg.0
    IL_007a:  /* 28   | (06)000044       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArgumentList() /* 06000044 */
    IL_007f:  /* 13   | 04               */ stloc.s    V_4
    IL_0081:  /* 02   |                  */ ldarg.0
    IL_0082:  /* 03   |                  */ ldarg.1
    IL_0083:  /* 07   |                  */ ldloc.1
    IL_0084:  /* 04   |                  */ ldarg.2
    IL_0085:  /* 14   |                  */ ldnull
    IL_0086:  /* FE01 |                  */ ceq
    IL_0088:  /* 11   | 04               */ ldloc.s    V_4
    IL_008a:  /* 12   | 05               */ ldloca.s   V_5
    IL_008c:  /* 28   | (06)000054       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                   string,
                                                                                                                                   bool,
                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                   class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000054 */
    IL_0091:  /* 13   | 08               */ stloc.s    V_8
    IL_0093:  /* 11   | 08               */ ldloc.s    V_8
    IL_0095:  /* 45   | 02000000         */ switch     ( 
              /*      | 05000000         */             IL_00a7,
              /*      | 2B000000         */             IL_00cd)
    IL_00a2:  /* 38   | B3000000         */ br         IL_015a

    IL_00a7:  /* 02   |                  */ ldarg.0
    IL_00a8:  /* 06   |                  */ ldloc.0
    IL_00a9:  /* 72   | (70)00091F       */ ldstr      "No applicable method '{0}' exists in type '{1}'" /* 7000091F */
    IL_00ae:  /* 18   |                  */ ldc.i4.2
    IL_00af:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00b4:  /* 13   | 09               */ stloc.s    V_9
    IL_00b6:  /* 11   | 09               */ ldloc.s    V_9
    IL_00b8:  /* 16   |                  */ ldc.i4.0
    IL_00b9:  /* 07   |                  */ ldloc.1
    IL_00ba:  /* A2   |                  */ stelem.ref
    IL_00bb:  /* 11   | 09               */ ldloc.s    V_9
    IL_00bd:  /* 17   |                  */ ldc.i4.1
    IL_00be:  /* 03   |                  */ ldarg.1
    IL_00bf:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_00c4:  /* A2   |                  */ stelem.ref
    IL_00c5:  /* 11   | 09               */ ldloc.s    V_9
    IL_00c7:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_00cc:  /* 7A   |                  */ throw

    IL_00cd:  /* 11   | 05               */ ldloc.s    V_5
    IL_00cf:  /* 74   | (01)000018       */ castclass  [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/
    IL_00d4:  /* 13   | 06               */ stloc.s    V_6
    IL_00d6:  /* 11   | 06               */ ldloc.s    V_6
    IL_00d8:  /* 6F   | (0A)00009F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_DeclaringType() /* 0A00009F */
    IL_00dd:  /* 28   | (06)000047       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsPredefinedType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000047 */
    IL_00e2:  /* 2D   | 27               */ brtrue.s   IL_010b

    IL_00e4:  /* 02   |                  */ ldarg.0
    IL_00e5:  /* 06   |                  */ ldloc.0
    IL_00e6:  /* 72   | (70)00097F       */ ldstr      "Methods on type '{0}' are not accessible" /* 7000097F */
    IL_00eb:  /* 17   |                  */ ldc.i4.1
    IL_00ec:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00f1:  /* 13   | 0A               */ stloc.s    V_10
    IL_00f3:  /* 11   | 0A               */ ldloc.s    V_10
    IL_00f5:  /* 16   |                  */ ldc.i4.0
    IL_00f6:  /* 11   | 06               */ ldloc.s    V_6
    IL_00f8:  /* 6F   | (0A)00009F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_DeclaringType() /* 0A00009F */
    IL_00fd:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0102:  /* A2   |                  */ stelem.ref
    IL_0103:  /* 11   | 0A               */ ldloc.s    V_10
    IL_0105:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_010a:  /* 7A   |                  */ throw

    IL_010b:  /* 11   | 06               */ ldloc.s    V_6
    IL_010d:  /* 6F   | (0A)0000A0       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/::get_ReturnType() /* 0A0000A0 */
    IL_0112:  /* D0   | (01)000068       */ ldtoken    [mscorlib/*23000001*/]System.Void/*01000068*/
    IL_0117:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_011c:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0121:  /* 2C   | 2C               */ brfalse.s  IL_014f

    IL_0123:  /* 02   |                  */ ldarg.0
    IL_0124:  /* 06   |                  */ ldloc.0
    IL_0125:  /* 72   | (70)0009D1       */ ldstr      "Method '{0}' in type '{1}' does not return a value" /* 700009D1 */
    IL_012a:  /* 18   |                  */ ldc.i4.2
    IL_012b:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0130:  /* 13   | 0B               */ stloc.s    V_11
    IL_0132:  /* 11   | 0B               */ ldloc.s    V_11
    IL_0134:  /* 16   |                  */ ldc.i4.0
    IL_0135:  /* 07   |                  */ ldloc.1
    IL_0136:  /* A2   |                  */ stelem.ref
    IL_0137:  /* 11   | 0B               */ ldloc.s    V_11
    IL_0139:  /* 17   |                  */ ldc.i4.1
    IL_013a:  /* 11   | 06               */ ldloc.s    V_6
    IL_013c:  /* 6F   | (0A)00009F       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_DeclaringType() /* 0A00009F */
    IL_0141:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0146:  /* A2   |                  */ stelem.ref
    IL_0147:  /* 11   | 0B               */ ldloc.s    V_11
    IL_0149:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_014e:  /* 7A   |                  */ throw

    IL_014f:  /* 04   |                  */ ldarg.2
    IL_0150:  /* 11   | 06               */ ldloc.s    V_6
    IL_0152:  /* 11   | 04               */ ldloc.s    V_4
    IL_0154:  /* 28   | (0A)0000A1       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A0000A1 */
    IL_0159:  /* 2A   |                  */ ret

    IL_015a:  /* 02   |                  */ ldarg.0
    IL_015b:  /* 06   |                  */ ldloc.0
    IL_015c:  /* 72   | (70)000A37       */ ldstr      "Ambiguous invocation of method '{0}' in type '{1}'" /* 70000A37 */
    IL_0161:  /* 18   |                  */ ldc.i4.2
    IL_0162:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0167:  /* 13   | 0C               */ stloc.s    V_12
    IL_0169:  /* 11   | 0C               */ ldloc.s    V_12
    IL_016b:  /* 16   |                  */ ldc.i4.0
    IL_016c:  /* 07   |                  */ ldloc.1
    IL_016d:  /* A2   |                  */ stelem.ref
    IL_016e:  /* 11   | 0C               */ ldloc.s    V_12
    IL_0170:  /* 17   |                  */ ldc.i4.1
    IL_0171:  /* 03   |                  */ ldarg.1
    IL_0172:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0177:  /* A2   |                  */ stelem.ref
    IL_0178:  /* 11   | 0C               */ ldloc.s    V_12
    IL_017a:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_017f:  /* 7A   |                  */ throw

    IL_0180:  /* 02   |                  */ ldarg.0
    IL_0181:  /* 03   |                  */ ldarg.1
    IL_0182:  /* 07   |                  */ ldloc.1
    IL_0183:  /* 04   |                  */ ldarg.2
    IL_0184:  /* 14   |                  */ ldnull
    IL_0185:  /* FE01 |                  */ ceq
    IL_0187:  /* 28   | (06)000053       */ call       instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindPropertyOrField(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                           string,
                                                                                                                                                                                                           bool) /* 06000053 */
    IL_018c:  /* 13   | 07               */ stloc.s    V_7
    IL_018e:  /* 11   | 07               */ ldloc.s    V_7
    IL_0190:  /* 14   |                  */ ldnull
    IL_0191:  /* 28   | (0A)0000A2       */ call       bool [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::op_Equality(class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/,
                                                                                                                                        class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/) /* 0A0000A2 */
    IL_0196:  /* 2C   | 26               */ brfalse.s  IL_01be

    IL_0198:  /* 02   |                  */ ldarg.0
    IL_0199:  /* 06   |                  */ ldloc.0
    IL_019a:  /* 72   | (70)000A9D       */ ldstr      "No property or field '{0}' exists in type '{1}'" /* 70000A9D */
    IL_019f:  /* 18   |                  */ ldc.i4.2
    IL_01a0:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_01a5:  /* 13   | 0D               */ stloc.s    V_13
    IL_01a7:  /* 11   | 0D               */ ldloc.s    V_13
    IL_01a9:  /* 16   |                  */ ldc.i4.0
    IL_01aa:  /* 07   |                  */ ldloc.1
    IL_01ab:  /* A2   |                  */ stelem.ref
    IL_01ac:  /* 11   | 0D               */ ldloc.s    V_13
    IL_01ae:  /* 17   |                  */ ldc.i4.1
    IL_01af:  /* 03   |                  */ ldarg.1
    IL_01b0:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_01b5:  /* A2   |                  */ stelem.ref
    IL_01b6:  /* 11   | 0D               */ ldloc.s    V_13
    IL_01b8:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_01bd:  /* 7A   |                  */ throw

    IL_01be:  /* 11   | 07               */ ldloc.s    V_7
    IL_01c0:  /* 75   | (01)00003E       */ isinst     [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/
    IL_01c5:  /* 2D   | 0E               */ brtrue.s   IL_01d5

    IL_01c7:  /* 04   |                  */ ldarg.2
    IL_01c8:  /* 11   | 07               */ ldloc.s    V_7
    IL_01ca:  /* 74   | (01)000012       */ castclass  [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/
    IL_01cf:  /* 28   | (0A)0000A3       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MemberExpression/*01000061*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Field(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                          class [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/) /* 0A0000A3 */
    IL_01d4:  /* 2A   |                  */ ret

    IL_01d5:  /* 04   |                  */ ldarg.2
    IL_01d6:  /* 11   | 07               */ ldloc.s    V_7
    IL_01d8:  /* 74   | (01)00003E       */ castclass  [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/
    IL_01dd:  /* 28   | (0A)0000A4       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MemberExpression/*01000061*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Property(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/) /* 0A0000A4 */
    IL_01e2:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseMemberAccess

  .method /*06000042*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          FindGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/ generic,
                          class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 02 12 21 12 21 12 21
  {
    // Method begins at RVA 0x42a4
    // Code size       124 (0x7c)
    .maxstack  2
    .locals /*11000028*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_2,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_3,
             int32 V_4)
    IL_0000:  /* 2B   | 5B               */ br.s       IL_005d

    IL_0002:  /* 03   |                  */ ldarg.1
    IL_0003:  /* 6F   | (0A)0000A5       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsGenericType() /* 0A0000A5 */
    IL_0008:  /* 2C   | 10               */ brfalse.s  IL_001a

    IL_000a:  /* 03   |                  */ ldarg.1
    IL_000b:  /* 6F   | (0A)0000A6       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetGenericTypeDefinition() /* 0A0000A6 */
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0016:  /* 2C   | 02               */ brfalse.s  IL_001a

    IL_0018:  /* 03   |                  */ ldarg.1
    IL_0019:  /* 2A   |                  */ ret

    IL_001a:  /* 02   |                  */ ldarg.0
    IL_001b:  /* 6F   | (0A)00009D       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsInterface() /* 0A00009D */
    IL_0020:  /* 2C   | 33               */ brfalse.s  IL_0055

    IL_0022:  /* 03   |                  */ ldarg.1
    IL_0023:  /* 6F   | (0A)0000A7       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetInterfaces() /* 0A0000A7 */
    IL_0028:  /* 0D   |                  */ stloc.3
    IL_0029:  /* 16   |                  */ ldc.i4.0
    IL_002a:  /* 13   | 04               */ stloc.s    V_4
    IL_002c:  /* 2B   | 20               */ br.s       IL_004e

    IL_002e:  /* 09   |                  */ ldloc.3
    IL_002f:  /* 11   | 04               */ ldloc.s    V_4
    IL_0031:  /* 9A   |                  */ ldelem.ref
    IL_0032:  /* 0A   |                  */ stloc.0
    IL_0033:  /* 02   |                  */ ldarg.0
    IL_0034:  /* 06   |                  */ ldloc.0
    IL_0035:  /* 28   | (06)000042       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindGenericType(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000042 */
    IL_003a:  /* 0B   |                  */ stloc.1
    IL_003b:  /* 07   |                  */ ldloc.1
    IL_003c:  /* 14   |                  */ ldnull
    IL_003d:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0042:  /* 2C   | 04               */ brfalse.s  IL_0048

    IL_0044:  /* 07   |                  */ ldloc.1
    IL_0045:  /* 0C   |                  */ stloc.2
    IL_0046:  /* DE   | 32               */ leave.s    IL_007a

    IL_0048:  /* 11   | 04               */ ldloc.s    V_4
    IL_004a:  /* 17   |                  */ ldc.i4.1
    IL_004b:  /* 58   |                  */ add
    IL_004c:  /* 13   | 04               */ stloc.s    V_4
    IL_004e:  /* 11   | 04               */ ldloc.s    V_4
    IL_0050:  /* 09   |                  */ ldloc.3
    IL_0051:  /* 8E   |                  */ ldlen
    IL_0052:  /* 69   |                  */ conv.i4
    IL_0053:  /* 32   | D9               */ blt.s      IL_002e

    IL_0055:  /* 03   |                  */ ldarg.1
    IL_0056:  /* 6F   | (0A)0000A8       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::get_BaseType() /* 0A0000A8 */
    IL_005b:  /* 10   | 01               */ starg.s    'type'
    IL_005d:  /* 03   |                  */ ldarg.1
    IL_005e:  /* 14   |                  */ ldnull
    IL_005f:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0064:  /* 2C   | 12               */ brfalse.s  IL_0078

    IL_0066:  /* 03   |                  */ ldarg.1
    IL_0067:  /* D0   | (01)000001       */ ldtoken    [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_006c:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0071:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0076:  /* 2D   | 8A               */ brtrue.s   IL_0002

    IL_0078:  /* 14   |                  */ ldnull
    IL_0079:  /* 2A   |                  */ ret

    IL_007a:  /* 08   |                  */ ldloc.2
    IL_007b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::FindGenericType

  .method /*06000043*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseAggregate(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 'instance',
                         class [mscorlib/*23000001*/]System.Type/*01000008*/ elementType,
                         string methodName,
                         int32 errorPos) cil managed
  // SIG: 20 04 12 25 12 25 12 21 0E 08
  {
    // Method begins at RVA 0x432c
    // Code size       268 (0x10c)
    .maxstack  6
    .locals /*11000029*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_2,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_3,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_4,
             object[] V_5,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_6,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_7,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_8,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_9,
             class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[] V_10)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)000018       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 04   |                  */ ldarg.2
    IL_0008:  /* 72   | (70)000061       */ ldstr      "" /* 70000061 */
    IL_000d:  /* 28   | (0A)00001E       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Parameter(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                                 string) /* 0A00001E */
    IL_0012:  /* 0B   |                  */ stloc.1
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 07   |                  */ ldloc.1
    IL_0015:  /* 7D   | (04)000018       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_001a:  /* 02   |                  */ ldarg.0
    IL_001b:  /* 28   | (06)000044       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArgumentList() /* 06000044 */
    IL_0020:  /* 0C   |                  */ stloc.2
    IL_0021:  /* 02   |                  */ ldarg.0
    IL_0022:  /* 06   |                  */ ldloc.0
    IL_0023:  /* 7D   | (04)000018       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::it /* 04000018 */
    IL_0028:  /* 02   |                  */ ldarg.0
    IL_0029:  /* D0   | (02)000015       */ ldtoken    System.Linq.Dynamic.ExpressionParser/*0200000A*//IEnumerableSignatures/*02000015*/
    IL_002e:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0033:  /* 05   |                  */ ldarg.3
    IL_0034:  /* 16   |                  */ ldc.i4.0
    IL_0035:  /* 08   |                  */ ldloc.2
    IL_0036:  /* 12   | 03               */ ldloca.s   V_3
    IL_0038:  /* 28   | (06)000054       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                   string,
                                                                                                                                   bool,
                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                   class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000054 */
    IL_003d:  /* 17   |                  */ ldc.i4.1
    IL_003e:  /* 2E   | 1D               */ beq.s      IL_005d

    IL_0040:  /* 02   |                  */ ldarg.0
    IL_0041:  /* 0E   | 04               */ ldarg.s    errorPos
    IL_0043:  /* 72   | (70)000AFD       */ ldstr      "No applicable aggregate method '{0}' exists" /* 70000AFD */
    IL_0048:  /* 17   |                  */ ldc.i4.1
    IL_0049:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_004e:  /* 13   | 05               */ stloc.s    V_5
    IL_0050:  /* 11   | 05               */ ldloc.s    V_5
    IL_0052:  /* 16   |                  */ ldc.i4.0
    IL_0053:  /* 05   |                  */ ldarg.3
    IL_0054:  /* A2   |                  */ stelem.ref
    IL_0055:  /* 11   | 05               */ ldloc.s    V_5
    IL_0057:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_005c:  /* 7A   |                  */ throw

    IL_005d:  /* 09   |                  */ ldloc.3
    IL_005e:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_0063:  /* 72   | (70)000B55       */ ldstr      "Min" /* 70000B55 */
    IL_0068:  /* 28   | (0A)0000A9       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::op_Equality(string,
                                                                                                                         string) /* 0A0000A9 */
    IL_006d:  /* 2D   | 12               */ brtrue.s   IL_0081

    IL_006f:  /* 09   |                  */ ldloc.3
    IL_0070:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_0075:  /* 72   | (70)000B5D       */ ldstr      "Max" /* 70000B5D */
    IL_007a:  /* 28   | (0A)0000A9       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::op_Equality(string,
                                                                                                                         string) /* 0A0000A9 */
    IL_007f:  /* 2C   | 1F               */ brfalse.s  IL_00a0

    IL_0081:  /* 18   |                  */ ldc.i4.2
    IL_0082:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0087:  /* 13   | 06               */ stloc.s    V_6
    IL_0089:  /* 11   | 06               */ ldloc.s    V_6
    IL_008b:  /* 16   |                  */ ldc.i4.0
    IL_008c:  /* 04   |                  */ ldarg.2
    IL_008d:  /* A2   |                  */ stelem.ref
    IL_008e:  /* 11   | 06               */ ldloc.s    V_6
    IL_0090:  /* 17   |                  */ ldc.i4.1
    IL_0091:  /* 08   |                  */ ldloc.2
    IL_0092:  /* 16   |                  */ ldc.i4.0
    IL_0093:  /* 9A   |                  */ ldelem.ref
    IL_0094:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0099:  /* A2   |                  */ stelem.ref
    IL_009a:  /* 11   | 06               */ ldloc.s    V_6
    IL_009c:  /* 13   | 04               */ stloc.s    V_4
    IL_009e:  /* 2B   | 11               */ br.s       IL_00b1

    IL_00a0:  /* 17   |                  */ ldc.i4.1
    IL_00a1:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_00a6:  /* 13   | 07               */ stloc.s    V_7
    IL_00a8:  /* 11   | 07               */ ldloc.s    V_7
    IL_00aa:  /* 16   |                  */ ldc.i4.0
    IL_00ab:  /* 04   |                  */ ldarg.2
    IL_00ac:  /* A2   |                  */ stelem.ref
    IL_00ad:  /* 11   | 07               */ ldloc.s    V_7
    IL_00af:  /* 13   | 04               */ stloc.s    V_4
    IL_00b1:  /* 08   |                  */ ldloc.2
    IL_00b2:  /* 8E   |                  */ ldlen
    IL_00b3:  /* 69   |                  */ conv.i4
    IL_00b4:  /* 2D   | 12               */ brtrue.s   IL_00c8

    IL_00b6:  /* 17   |                  */ ldc.i4.1
    IL_00b7:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_00bc:  /* 13   | 08               */ stloc.s    V_8
    IL_00be:  /* 11   | 08               */ ldloc.s    V_8
    IL_00c0:  /* 16   |                  */ ldc.i4.0
    IL_00c1:  /* 03   |                  */ ldarg.1
    IL_00c2:  /* A2   |                  */ stelem.ref
    IL_00c3:  /* 11   | 08               */ ldloc.s    V_8
    IL_00c5:  /* 0C   |                  */ stloc.2
    IL_00c6:  /* 2B   | 2B               */ br.s       IL_00f3

    IL_00c8:  /* 18   |                  */ ldc.i4.2
    IL_00c9:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_00ce:  /* 13   | 09               */ stloc.s    V_9
    IL_00d0:  /* 11   | 09               */ ldloc.s    V_9
    IL_00d2:  /* 16   |                  */ ldc.i4.0
    IL_00d3:  /* 03   |                  */ ldarg.1
    IL_00d4:  /* A2   |                  */ stelem.ref
    IL_00d5:  /* 11   | 09               */ ldloc.s    V_9
    IL_00d7:  /* 17   |                  */ ldc.i4.1
    IL_00d8:  /* 08   |                  */ ldloc.2
    IL_00d9:  /* 16   |                  */ ldc.i4.0
    IL_00da:  /* 9A   |                  */ ldelem.ref
    IL_00db:  /* 17   |                  */ ldc.i4.1
    IL_00dc:  /* 8D   | (01)00000B       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/
    IL_00e1:  /* 13   | 0A               */ stloc.s    V_10
    IL_00e3:  /* 11   | 0A               */ ldloc.s    V_10
    IL_00e5:  /* 16   |                  */ ldc.i4.0
    IL_00e6:  /* 07   |                  */ ldloc.1
    IL_00e7:  /* A2   |                  */ stelem.ref
    IL_00e8:  /* 11   | 0A               */ ldloc.s    V_10
    IL_00ea:  /* 28   | (0A)000021       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.LambdaExpression/*0100000A*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Lambda(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [System.Core/*23000002*/]System.Linq.Expressions.ParameterExpression/*0100000B*/[]) /* 0A000021 */
    IL_00ef:  /* A2   |                  */ stelem.ref
    IL_00f0:  /* 11   | 09               */ ldloc.s    V_9
    IL_00f2:  /* 0C   |                  */ stloc.2
    IL_00f3:  /* D0   | (01)000041       */ ldtoken    [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/
    IL_00f8:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00fd:  /* 09   |                  */ ldloc.3
    IL_00fe:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_0103:  /* 11   | 04               */ ldloc.s    V_4
    IL_0105:  /* 08   |                  */ ldloc.2
    IL_0106:  /* 28   | (0A)00001A       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                             string,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Type/*01000008*/[],
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A00001A */
    IL_010b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseAggregate

  .method /*06000044*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] 
          ParseArgumentList() cil managed
  // SIG: 20 00 1D 12 25
  {
    // Method begins at RVA 0x4444
    // Code size       70 (0x46)
    .maxstack  3
    .locals /*1100002A*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0003:  /* 72   | (70)000473       */ ldstr      "'(' expected" /* 70000473 */
    IL_0008:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_000d:  /* 02   |                  */ ldarg.0
    IL_000e:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0013:  /* 02   |                  */ ldarg.0
    IL_0014:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0019:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_001e:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_0020:  /* 33   | 08               */ bne.un.s   IL_002a

    IL_0022:  /* 16   |                  */ ldc.i4.0
    IL_0023:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0028:  /* 2B   | 06               */ br.s       IL_0030

    IL_002a:  /* 02   |                  */ ldarg.0
    IL_002b:  /* 28   | (06)000045       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArguments() /* 06000045 */
    IL_0030:  /* 0A   |                  */ stloc.0
    IL_0031:  /* 02   |                  */ ldarg.0
    IL_0032:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_0034:  /* 72   | (70)00070D       */ ldstr      "')' or ',' expected" /* 7000070D */
    IL_0039:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_003e:  /* 02   |                  */ ldarg.0
    IL_003f:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0044:  /* 06   |                  */ ldloc.0
    IL_0045:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseArgumentList

  .method /*06000045*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] 
          ParseArguments() cil managed
  // SIG: 20 00 1D 12 25
  {
    // Method begins at RVA 0x4498
    // Code size       48 (0x30)
    .maxstack  2
    .locals /*1100002B*/ init (class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/> V_0)
    IL_0000:  /* 73   | (0A)00008E       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::.ctor() /* 0A00008E */
    IL_0005:  /* 0A   |                  */ stloc.0
    IL_0006:  /* 06   |                  */ ldloc.0
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 28   | (06)00002B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseExpression() /* 0600002B */
    IL_000d:  /* 6F   | (0A)000090       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::Add(!0) /* 0A000090 */
    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0018:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_001d:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_001f:  /* 33   | 08               */ bne.un.s   IL_0029

    IL_0021:  /* 02   |                  */ ldarg.0
    IL_0022:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0027:  /* 2B   | DD               */ br.s       IL_0006

    IL_0029:  /* 06   |                  */ ldloc.0
    IL_002a:  /* 6F   | (0A)0000AA       */ callvirt   instance !0[] class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/>/*1B000010*/::ToArray() /* 0A0000AA */
    IL_002f:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseArguments

  .method /*06000046*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          ParseElementAccess(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ expr) cil managed
  // SIG: 20 01 12 25 12 25
  {
    // Method begins at RVA 0x44d4
    // Code size       284 (0x11c)
    .maxstack  6
    .locals /*1100002C*/ init (int32 V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_2,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_3,
             int32 V_4,
             object[] V_5,
             object[] V_6)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000b:  /* 0A   |                  */ stloc.0
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 1F   | 16               */ ldc.i4.s   22
    IL_000f:  /* 72   | (70)000473       */ ldstr      "'(' expected" /* 70000473 */
    IL_0014:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_001f:  /* 02   |                  */ ldarg.0
    IL_0020:  /* 28   | (06)000045       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseArguments() /* 06000045 */
    IL_0025:  /* 0B   |                  */ stloc.1
    IL_0026:  /* 02   |                  */ ldarg.0
    IL_0027:  /* 1F   | 17               */ ldc.i4.s   23
    IL_0029:  /* 72   | (70)000B65       */ ldstr      "']' or ',' expected" /* 70000B65 */
    IL_002e:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_0033:  /* 02   |                  */ ldarg.0
    IL_0034:  /* 28   | (06)00006E       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextToken() /* 0600006E */
    IL_0039:  /* 03   |                  */ ldarg.1
    IL_003a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_003f:  /* 6F   | (0A)0000AB       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsArray() /* 0A0000AB */
    IL_0044:  /* 2C   | 5A               */ brfalse.s  IL_00a0

    IL_0046:  /* 03   |                  */ ldarg.1
    IL_0047:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_004c:  /* 6F   | (0A)0000AC       */ callvirt   instance int32 [mscorlib/*23000001*/]System.Type/*01000008*/::GetArrayRank() /* 0A0000AC */
    IL_0051:  /* 17   |                  */ ldc.i4.1
    IL_0052:  /* 33   | 06               */ bne.un.s   IL_005a

    IL_0054:  /* 07   |                  */ ldloc.1
    IL_0055:  /* 8E   |                  */ ldlen
    IL_0056:  /* 69   |                  */ conv.i4
    IL_0057:  /* 17   |                  */ ldc.i4.1
    IL_0058:  /* 2E   | 13               */ beq.s      IL_006d

    IL_005a:  /* 02   |                  */ ldarg.0
    IL_005b:  /* 06   |                  */ ldloc.0
    IL_005c:  /* 72   | (70)000B8D       */ ldstr      "Indexing of multi-dimensional arrays is not suppor"
    + "ted" /* 70000B8D */
    IL_0061:  /* 16   |                  */ ldc.i4.0
    IL_0062:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0067:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_006c:  /* 7A   |                  */ throw

    IL_006d:  /* 02   |                  */ ldarg.0
    IL_006e:  /* 07   |                  */ ldloc.1
    IL_006f:  /* 16   |                  */ ldc.i4.0
    IL_0070:  /* 9A   |                  */ ldelem.ref
    IL_0071:  /* D0   | (01)00003C       */ ldtoken    [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0076:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_007b:  /* 17   |                  */ ldc.i4.1
    IL_007c:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_0081:  /* 0C   |                  */ stloc.2
    IL_0082:  /* 08   |                  */ ldloc.2
    IL_0083:  /* 2D   | 13               */ brtrue.s   IL_0098

    IL_0085:  /* 02   |                  */ ldarg.0
    IL_0086:  /* 06   |                  */ ldloc.0
    IL_0087:  /* 72   | (70)000BF9       */ ldstr      "Array index must be an integer expression" /* 70000BF9 */
    IL_008c:  /* 16   |                  */ ldc.i4.0
    IL_008d:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0092:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0097:  /* 7A   |                  */ throw

    IL_0098:  /* 03   |                  */ ldarg.1
    IL_0099:  /* 08   |                  */ ldloc.2
    IL_009a:  /* 28   | (0A)0000AD       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::ArrayIndex(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000AD */
    IL_009f:  /* 2A   |                  */ ret

    IL_00a0:  /* 02   |                  */ ldarg.0
    IL_00a1:  /* 03   |                  */ ldarg.1
    IL_00a2:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00a7:  /* 07   |                  */ ldloc.1
    IL_00a8:  /* 12   | 03               */ ldloca.s   V_3
    IL_00aa:  /* 28   | (06)000055       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindIndexer(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000055 */
    IL_00af:  /* 13   | 04               */ stloc.s    V_4
    IL_00b1:  /* 11   | 04               */ ldloc.s    V_4
    IL_00b3:  /* 45   | 02000000         */ switch     ( 
              /*      | 02000000         */             IL_00c2,
              /*      | 28000000         */             IL_00e8)
    IL_00c0:  /* 2B   | 34               */ br.s       IL_00f6

    IL_00c2:  /* 02   |                  */ ldarg.0
    IL_00c3:  /* 06   |                  */ ldloc.0
    IL_00c4:  /* 72   | (70)000C4D       */ ldstr      "No applicable indexer exists in type '{0}'" /* 70000C4D */
    IL_00c9:  /* 17   |                  */ ldc.i4.1
    IL_00ca:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_00cf:  /* 13   | 05               */ stloc.s    V_5
    IL_00d1:  /* 11   | 05               */ ldloc.s    V_5
    IL_00d3:  /* 16   |                  */ ldc.i4.0
    IL_00d4:  /* 03   |                  */ ldarg.1
    IL_00d5:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00da:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_00df:  /* A2   |                  */ stelem.ref
    IL_00e0:  /* 11   | 05               */ ldloc.s    V_5
    IL_00e2:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_00e7:  /* 7A   |                  */ throw

    IL_00e8:  /* 03   |                  */ ldarg.1
    IL_00e9:  /* 09   |                  */ ldloc.3
    IL_00ea:  /* 74   | (01)000018       */ castclass  [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/
    IL_00ef:  /* 07   |                  */ ldloc.1
    IL_00f0:  /* 28   | (0A)0000A1       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A0000A1 */
    IL_00f5:  /* 2A   |                  */ ret

    IL_00f6:  /* 02   |                  */ ldarg.0
    IL_00f7:  /* 06   |                  */ ldloc.0
    IL_00f8:  /* 72   | (70)000CA3       */ ldstr      "Ambiguous invocation of indexer in type '{0}'" /* 70000CA3 */
    IL_00fd:  /* 17   |                  */ ldc.i4.1
    IL_00fe:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0103:  /* 13   | 06               */ stloc.s    V_6
    IL_0105:  /* 11   | 06               */ ldloc.s    V_6
    IL_0107:  /* 16   |                  */ ldc.i4.0
    IL_0108:  /* 03   |                  */ ldarg.1
    IL_0109:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_010e:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0113:  /* A2   |                  */ stelem.ref
    IL_0114:  /* 11   | 06               */ ldloc.s    V_6
    IL_0116:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_011b:  /* 7A   |                  */ throw
  } // end of method ExpressionParser::ParseElementAccess

  .method /*06000047*/ private hidebysig static 
          bool  IsPredefinedType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x45fc
    // Code size       41 (0x29)
    .maxstack  2
    .locals /*1100002D*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             bool V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_2,
             int32 V_3)
    IL_0000:  /* 7E   | (04)00000D       */ ldsfld     class [mscorlib/*23000001*/]System.Type/*01000008*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::predefinedTypes /* 0400000D */
    IL_0005:  /* 0C   |                  */ stloc.2
    IL_0006:  /* 16   |                  */ ldc.i4.0
    IL_0007:  /* 0D   |                  */ stloc.3
    IL_0008:  /* 2B   | 15               */ br.s       IL_001f

    IL_000a:  /* 08   |                  */ ldloc.2
    IL_000b:  /* 09   |                  */ ldloc.3
    IL_000c:  /* 9A   |                  */ ldelem.ref
    IL_000d:  /* 0A   |                  */ stloc.0
    IL_000e:  /* 06   |                  */ ldloc.0
    IL_000f:  /* 02   |                  */ ldarg.0
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 04               */ brfalse.s  IL_001b

    IL_0017:  /* 17   |                  */ ldc.i4.1
    IL_0018:  /* 0B   |                  */ stloc.1
    IL_0019:  /* DE   | 0C               */ leave.s    IL_0027

    IL_001b:  /* 09   |                  */ ldloc.3
    IL_001c:  /* 17   |                  */ ldc.i4.1
    IL_001d:  /* 58   |                  */ add
    IL_001e:  /* 0D   |                  */ stloc.3
    IL_001f:  /* 09   |                  */ ldloc.3
    IL_0020:  /* 08   |                  */ ldloc.2
    IL_0021:  /* 8E   |                  */ ldlen
    IL_0022:  /* 69   |                  */ conv.i4
    IL_0023:  /* 32   | E5               */ blt.s      IL_000a

    IL_0025:  /* 16   |                  */ ldc.i4.0
    IL_0026:  /* 2A   |                  */ ret

    IL_0027:  /* 07   |                  */ ldloc.1
    IL_0028:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsPredefinedType

  .method /*06000048*/ private hidebysig static 
          bool  IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x4631
    // Code size       32 (0x20)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 6F   | (0A)0000A5       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsGenericType() /* 0A0000A5 */
    IL_0006:  /* 2C   | 16               */ brfalse.s  IL_001e

    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 6F   | (0A)0000A6       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetGenericTypeDefinition() /* 0A0000A6 */
    IL_000e:  /* D0   | (01)000019       */ ldtoken    [mscorlib/*23000001*/]System.Nullable`1/*01000019*/
    IL_0013:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0018:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_001d:  /* 2A   |                  */ ret

    IL_001e:  /* 16   |                  */ ldc.i4.0
    IL_001f:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsNullableType

  .method /*06000049*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Type/*01000008*/ 
          GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 12 21 12 21
  {
    // Method begins at RVA 0x4652
    // Code size       19 (0x13)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000048       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000048 */
    IL_0006:  /* 2D   | 02               */ brtrue.s   IL_000a

    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 2A   |                  */ ret

    IL_000a:  /* 02   |                  */ ldarg.0
    IL_000b:  /* 6F   | (0A)00009E       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetGenericArguments() /* 0A00009E */
    IL_0010:  /* 16   |                  */ ldc.i4.0
    IL_0011:  /* 9A   |                  */ ldelem.ref
    IL_0012:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GetNonNullableType

  .method /*0600004A*/ private hidebysig static 
          string  GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 0E 12 21
  {
    // Method begins at RVA 0x4668
    // Code size       39 (0x27)
    .maxstack  2
    .locals /*1100002E*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             string V_1)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0006:  /* 0A   |                  */ stloc.0
    IL_0007:  /* 06   |                  */ ldloc.0
    IL_0008:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_000d:  /* 0B   |                  */ stloc.1
    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 06   |                  */ ldloc.0
    IL_0010:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0015:  /* 2C   | 0E               */ brfalse.s  IL_0025

    IL_0017:  /* 07   |                  */ ldloc.1
    IL_0018:  /* 1F   | 3F               */ ldc.i4.s   63
    IL_001a:  /* 8C   | (01)00005A       */ box        [mscorlib/*23000001*/]System.Char/*0100005A*/
    IL_001f:  /* 28   | (0A)000041       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Concat(object,
                                                                                                                      object) /* 0A000041 */
    IL_0024:  /* 0B   |                  */ stloc.1
    IL_0025:  /* 07   |                  */ ldloc.1
    IL_0026:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GetTypeName

  .method /*0600004B*/ private hidebysig static 
          bool  IsNumericType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x469b
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00004E       */ call       int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNumericTypeKind(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004E */
    IL_0006:  /* 16   |                  */ ldc.i4.0
    IL_0007:  /* FE01 |                  */ ceq
    IL_0009:  /* 16   |                  */ ldc.i4.0
    IL_000a:  /* FE01 |                  */ ceq
    IL_000c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsNumericType

  .method /*0600004C*/ private hidebysig static 
          bool  IsSignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x46a9
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00004E       */ call       int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNumericTypeKind(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004E */
    IL_0006:  /* 18   |                  */ ldc.i4.2
    IL_0007:  /* FE01 |                  */ ceq
    IL_0009:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsSignedIntegralType

  .method /*0600004D*/ private hidebysig static 
          bool  IsUnsignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x46b4
    // Code size       10 (0xa)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)00004E       */ call       int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNumericTypeKind(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004E */
    IL_0006:  /* 19   |                  */ ldc.i4.3
    IL_0007:  /* FE01 |                  */ ceq
    IL_0009:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsUnsignedIntegralType

  .method /*0600004E*/ private hidebysig static 
          int32  GetNumericTypeKind(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 08 12 21
  {
    // Method begins at RVA 0x46c0
    // Code size       91 (0x5b)
    .maxstack  2
    .locals /*1100002F*/ init (valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0006:  /* 10   | 00               */ starg.s    'type'
    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 6F   | (0A)0000AE       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsEnum() /* 0A0000AE */
    IL_000e:  /* 2C   | 02               */ brfalse.s  IL_0012

    IL_0010:  /* 16   |                  */ ldc.i4.0
    IL_0011:  /* 2A   |                  */ ret

    IL_0012:  /* 02   |                  */ ldarg.0
    IL_0013:  /* 28   | (0A)0000AF       */ call       valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeCode(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000AF */
    IL_0018:  /* 0A   |                  */ stloc.0
    IL_0019:  /* 06   |                  */ ldloc.0
    IL_001a:  /* 1A   |                  */ ldc.i4.4
    IL_001b:  /* 59   |                  */ sub
    IL_001c:  /* 45   | 0C000000         */ switch     ( 
              /*      | 02000000         */             IL_0053,
              /*      | 04000000         */             IL_0055,
              /*      | 06000000         */             IL_0057,
              /*      | 04000000         */             IL_0055,
              /*      | 06000000         */             IL_0057,
              /*      | 04000000         */             IL_0055,
              /*      | 06000000         */             IL_0057,
              /*      | 04000000         */             IL_0055,
              /*      | 06000000         */             IL_0057,
              /*      | 02000000         */             IL_0053,
              /*      | 02000000         */             IL_0053,
              /*      | 02000000         */             IL_0053)
    IL_0051:  /* 2B   | 06               */ br.s       IL_0059

    IL_0053:  /* 17   |                  */ ldc.i4.1
    IL_0054:  /* 2A   |                  */ ret

    IL_0055:  /* 18   |                  */ ldc.i4.2
    IL_0056:  /* 2A   |                  */ ret

    IL_0057:  /* 19   |                  */ ldc.i4.3
    IL_0058:  /* 2A   |                  */ ret

    IL_0059:  /* 16   |                  */ ldc.i4.0
    IL_005a:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GetNumericTypeKind

  .method /*0600004F*/ private hidebysig static 
          bool  IsEnumType(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 02 12 21
  {
    // Method begins at RVA 0x4727
    // Code size       12 (0xc)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0006:  /* 6F   | (0A)0000AE       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsEnum() /* 0A0000AE */
    IL_000b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsEnumType

  .method /*06000050*/ private hidebysig 
          instance void  CheckAndPromoteOperand(class [mscorlib/*23000001*/]System.Type/*01000008*/ signatures,
                                                string opName,
                                                class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/& expr,
                                                int32 errorPos) cil managed
  // SIG: 20 04 01 12 21 0E 10 12 25 08
  {
    // Method begins at RVA 0x4734
    // Code size       81 (0x51)
    .maxstack  7
    .locals /*11000030*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_0,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_2,
             object[] V_3)
    IL_0000:  /* 17   |                  */ ldc.i4.1
    IL_0001:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0006:  /* 0C   |                  */ stloc.2
    IL_0007:  /* 08   |                  */ ldloc.2
    IL_0008:  /* 16   |                  */ ldc.i4.0
    IL_0009:  /* 05   |                  */ ldarg.3
    IL_000a:  /* 50   |                  */ ldind.ref
    IL_000b:  /* A2   |                  */ stelem.ref
    IL_000c:  /* 08   |                  */ ldloc.2
    IL_000d:  /* 0A   |                  */ stloc.0
    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 03   |                  */ ldarg.1
    IL_0010:  /* 72   | (70)000CFF       */ ldstr      "F" /* 70000CFF */
    IL_0015:  /* 16   |                  */ ldc.i4.0
    IL_0016:  /* 06   |                  */ ldloc.0
    IL_0017:  /* 12   | 01               */ ldloca.s   V_1
    IL_0019:  /* 28   | (06)000054       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                   string,
                                                                                                                                   bool,
                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                   class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000054 */
    IL_001e:  /* 17   |                  */ ldc.i4.1
    IL_001f:  /* 2E   | 2A               */ beq.s      IL_004b

    IL_0021:  /* 02   |                  */ ldarg.0
    IL_0022:  /* 0E   | 04               */ ldarg.s    errorPos
    IL_0024:  /* 72   | (70)000D03       */ ldstr      "Operator '{0}' incompatible with operand type '{1}'" /* 70000D03 */
    IL_0029:  /* 18   |                  */ ldc.i4.2
    IL_002a:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_002f:  /* 0D   |                  */ stloc.3
    IL_0030:  /* 09   |                  */ ldloc.3
    IL_0031:  /* 16   |                  */ ldc.i4.0
    IL_0032:  /* 04   |                  */ ldarg.2
    IL_0033:  /* A2   |                  */ stelem.ref
    IL_0034:  /* 09   |                  */ ldloc.3
    IL_0035:  /* 17   |                  */ ldc.i4.1
    IL_0036:  /* 06   |                  */ ldloc.0
    IL_0037:  /* 16   |                  */ ldc.i4.0
    IL_0038:  /* 9A   |                  */ ldelem.ref
    IL_0039:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_003e:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0043:  /* A2   |                  */ stelem.ref
    IL_0044:  /* 09   |                  */ ldloc.3
    IL_0045:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_004a:  /* 7A   |                  */ throw

    IL_004b:  /* 05   |                  */ ldarg.3
    IL_004c:  /* 06   |                  */ ldloc.0
    IL_004d:  /* 16   |                  */ ldc.i4.0
    IL_004e:  /* 9A   |                  */ ldelem.ref
    IL_004f:  /* 51   |                  */ stind.ref
    IL_0050:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::CheckAndPromoteOperand

  .method /*06000051*/ private hidebysig 
          instance void  CheckAndPromoteOperands(class [mscorlib/*23000001*/]System.Type/*01000008*/ signatures,
                                                 string opName,
                                                 class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/& left,
                                                 class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/& right,
                                                 int32 errorPos) cil managed
  // SIG: 20 05 01 12 21 0E 10 12 25 10 12 25 08
  {
    // Method begins at RVA 0x4794
    // Code size       66 (0x42)
    .maxstack  6
    .locals /*11000031*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_0,
             class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ V_1,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_2)
    IL_0000:  /* 18   |                  */ ldc.i4.2
    IL_0001:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0006:  /* 0C   |                  */ stloc.2
    IL_0007:  /* 08   |                  */ ldloc.2
    IL_0008:  /* 16   |                  */ ldc.i4.0
    IL_0009:  /* 05   |                  */ ldarg.3
    IL_000a:  /* 50   |                  */ ldind.ref
    IL_000b:  /* A2   |                  */ stelem.ref
    IL_000c:  /* 08   |                  */ ldloc.2
    IL_000d:  /* 17   |                  */ ldc.i4.1
    IL_000e:  /* 0E   | 04               */ ldarg.s    right
    IL_0010:  /* 50   |                  */ ldind.ref
    IL_0011:  /* A2   |                  */ stelem.ref
    IL_0012:  /* 08   |                  */ ldloc.2
    IL_0013:  /* 0A   |                  */ stloc.0
    IL_0014:  /* 02   |                  */ ldarg.0
    IL_0015:  /* 03   |                  */ ldarg.1
    IL_0016:  /* 72   | (70)000CFF       */ ldstr      "F" /* 70000CFF */
    IL_001b:  /* 16   |                  */ ldc.i4.0
    IL_001c:  /* 06   |                  */ ldloc.0
    IL_001d:  /* 12   | 01               */ ldloca.s   V_1
    IL_001f:  /* 28   | (06)000054       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                   string,
                                                                                                                                   bool,
                                                                                                                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                   class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000054 */
    IL_0024:  /* 17   |                  */ ldc.i4.1
    IL_0025:  /* 2E   | 0F               */ beq.s      IL_0036

    IL_0027:  /* 02   |                  */ ldarg.0
    IL_0028:  /* 04   |                  */ ldarg.2
    IL_0029:  /* 05   |                  */ ldarg.3
    IL_002a:  /* 50   |                  */ ldind.ref
    IL_002b:  /* 0E   | 04               */ ldarg.s    right
    IL_002d:  /* 50   |                  */ ldind.ref
    IL_002e:  /* 0E   | 05               */ ldarg.s    errorPos
    IL_0030:  /* 28   | (06)000052       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::IncompatibleOperandsError(string,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                     int32) /* 06000052 */
    IL_0035:  /* 7A   |                  */ throw

    IL_0036:  /* 05   |                  */ ldarg.3
    IL_0037:  /* 06   |                  */ ldloc.0
    IL_0038:  /* 16   |                  */ ldc.i4.0
    IL_0039:  /* 9A   |                  */ ldelem.ref
    IL_003a:  /* 51   |                  */ stind.ref
    IL_003b:  /* 0E   | 04               */ ldarg.s    right
    IL_003d:  /* 06   |                  */ ldloc.0
    IL_003e:  /* 17   |                  */ ldc.i4.1
    IL_003f:  /* 9A   |                  */ ldelem.ref
    IL_0040:  /* 51   |                  */ stind.ref
    IL_0041:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::CheckAndPromoteOperands

  .method /*06000052*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ 
          IncompatibleOperandsError(string opName,
                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right,
                                    int32 pos) cil managed
  // SIG: 20 04 12 0D 0E 12 25 12 25 08
  {
    // Method begins at RVA 0x47e4
    // Code size       54 (0x36)
    .maxstack  6
    .locals /*11000012*/ init (object[] V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 0E   | 04               */ ldarg.s    pos
    IL_0003:  /* 72   | (70)000D6B       */ ldstr      "Operator '{0}' incompatible with operand types '{1"
    + "}' and '{2}'" /* 70000D6B */
    IL_0008:  /* 19   |                  */ ldc.i4.3
    IL_0009:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_000e:  /* 0A   |                  */ stloc.0
    IL_000f:  /* 06   |                  */ ldloc.0
    IL_0010:  /* 16   |                  */ ldc.i4.0
    IL_0011:  /* 03   |                  */ ldarg.1
    IL_0012:  /* A2   |                  */ stelem.ref
    IL_0013:  /* 06   |                  */ ldloc.0
    IL_0014:  /* 17   |                  */ ldc.i4.1
    IL_0015:  /* 04   |                  */ ldarg.2
    IL_0016:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_001b:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_0020:  /* A2   |                  */ stelem.ref
    IL_0021:  /* 06   |                  */ ldloc.0
    IL_0022:  /* 18   |                  */ ldc.i4.2
    IL_0023:  /* 05   |                  */ ldarg.3
    IL_0024:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0029:  /* 28   | (06)00004A       */ call       string System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetTypeName(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004A */
    IL_002e:  /* A2   |                  */ stelem.ref
    IL_002f:  /* 06   |                  */ ldloc.0
    IL_0030:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0035:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IncompatibleOperandsError

  .method /*06000053*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/ 
          FindPropertyOrField(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                              string memberName,
                              bool staticAccess) cil managed
  // SIG: 20 03 12 55 12 21 0E 02
  {
    // Method begins at RVA 0x4828
    // Code size       88 (0x58)
    .maxstack  5
    .locals /*11000032*/ init (valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] V_2,
             class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/ V_3,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> V_4)
    IL_0000:  /* 1F   | 12               */ ldc.i4.s   18
    IL_0002:  /* 05   |                  */ ldarg.3
    IL_0003:  /* 2D   | 03               */ brtrue.s   IL_0008

    IL_0005:  /* 1A   |                  */ ldc.i4.4
    IL_0006:  /* 2B   | 01               */ br.s       IL_0009

    IL_0008:  /* 1E   |                  */ ldc.i4.8
    IL_0009:  /* 60   |                  */ or
    IL_000a:  /* 0A   |                  */ stloc.0
    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 28   | (06)000056       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::SelfAndBaseTypes(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000056 */
    IL_0011:  /* 6F   | (0A)0000B0       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000011*/::GetEnumerator() /* 0A0000B0 */
    IL_0016:  /* 13   | 04               */ stloc.s    V_4
    .try
    {
      IL_0018:  /* 2B   | 23               */ br.s       IL_003d

      IL_001a:  /* 11   | 04               */ ldloc.s    V_4
      IL_001c:  /* 6F   | (0A)0000B1       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000012*/::get_Current() /* 0A0000B1 */
      IL_0021:  /* 0B   |                  */ stloc.1
      IL_0022:  /* 07   |                  */ ldloc.1
      IL_0023:  /* 1F   | 14               */ ldc.i4.s   20
      IL_0025:  /* 06   |                  */ ldloc.0
      IL_0026:  /* 7E   | (0A)0000B2       */ ldsfld     class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/ [mscorlib/*23000001*/]System.Type/*01000008*/::FilterNameIgnoreCase /* 0A0000B2 */
      IL_002b:  /* 04   |                  */ ldarg.2
      IL_002c:  /* 6F   | (0A)0000B3       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::FindMembers(valuetype [mscorlib/*23000001*/]System.Reflection.MemberTypes/*0100006B*/,
                                                                                                                                                                                                    valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/,
                                                                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/,
                                                                                                                                                                                                    object) /* 0A0000B3 */
      IL_0031:  /* 0C   |                  */ stloc.2
      IL_0032:  /* 08   |                  */ ldloc.2
      IL_0033:  /* 8E   |                  */ ldlen
      IL_0034:  /* 69   |                  */ conv.i4
      IL_0035:  /* 2C   | 06               */ brfalse.s  IL_003d

      IL_0037:  /* 08   |                  */ ldloc.2
      IL_0038:  /* 16   |                  */ ldc.i4.0
      IL_0039:  /* 9A   |                  */ ldelem.ref
      IL_003a:  /* 0D   |                  */ stloc.3
      IL_003b:  /* DE   | 19               */ leave.s    IL_0056

      IL_003d:  /* 11   | 04               */ ldloc.s    V_4
      IL_003f:  /* 6F   | (0A)000022       */ callvirt   instance bool [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext() /* 0A000022 */
      IL_0044:  /* 2D   | D4               */ brtrue.s   IL_001a

      IL_0046:  /* DE   | 0C               */ leave.s    IL_0054

    }  // end .try
    finally
    {
      IL_0048:  /* 11   | 04               */ ldloc.s    V_4
      IL_004a:  /* 2C   | 07               */ brfalse.s  IL_0053

      IL_004c:  /* 11   | 04               */ ldloc.s    V_4
      IL_004e:  /* 6F   | (0A)000023       */ callvirt   instance void [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose() /* 0A000023 */
      IL_0053:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 18 00 30 48 00 0C 00 00 00 00
    IL_0054:  /* 14   |                  */ ldnull
    IL_0055:  /* 2A   |                  */ ret

    IL_0056:  /* 09   |                  */ ldloc.3
    IL_0057:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::FindPropertyOrField

  .method /*06000054*/ private hidebysig 
          instance int32  FindMethod(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                                     string methodName,
                                     bool staticAccess,
                                     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args,
                                     [out] class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/& 'method') cil managed
  // SIG: 20 05 08 12 21 0E 02 1D 12 25 10 12 59
  {
    // Method begins at RVA 0x489c
    // Code size       106 (0x6a)
    .maxstack  5
    .locals /*11000033*/ init (valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] V_2,
             int32 V_3,
             int32 V_4,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> V_5)
    IL_0000:  /* 1F   | 12               */ ldc.i4.s   18
    IL_0002:  /* 05   |                  */ ldarg.3
    IL_0003:  /* 2D   | 03               */ brtrue.s   IL_0008

    IL_0005:  /* 1A   |                  */ ldc.i4.4
    IL_0006:  /* 2B   | 01               */ br.s       IL_0009

    IL_0008:  /* 1E   |                  */ ldc.i4.8
    IL_0009:  /* 60   |                  */ or
    IL_000a:  /* 0A   |                  */ stloc.0
    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 28   | (06)000056       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::SelfAndBaseTypes(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000056 */
    IL_0011:  /* 6F   | (0A)0000B0       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000011*/::GetEnumerator() /* 0A0000B0 */
    IL_0016:  /* 13   | 05               */ stloc.s    V_5
    .try
    {
      IL_0018:  /* 2B   | 30               */ br.s       IL_004a

      IL_001a:  /* 11   | 05               */ ldloc.s    V_5
      IL_001c:  /* 6F   | (0A)0000B1       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000012*/::get_Current() /* 0A0000B1 */
      IL_0021:  /* 0B   |                  */ stloc.1
      IL_0022:  /* 07   |                  */ ldloc.1
      IL_0023:  /* 1E   |                  */ ldc.i4.8
      IL_0024:  /* 06   |                  */ ldloc.0
      IL_0025:  /* 7E   | (0A)0000B2       */ ldsfld     class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/ [mscorlib/*23000001*/]System.Type/*01000008*/::FilterNameIgnoreCase /* 0A0000B2 */
      IL_002a:  /* 04   |                  */ ldarg.2
      IL_002b:  /* 6F   | (0A)0000B3       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::FindMembers(valuetype [mscorlib/*23000001*/]System.Reflection.MemberTypes/*0100006B*/,
                                                                                                                                                                                                    valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/,
                                                                                                                                                                                                    class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/,
                                                                                                                                                                                                    object) /* 0A0000B3 */
      IL_0030:  /* 0C   |                  */ stloc.2
      IL_0031:  /* 02   |                  */ ldarg.0
      IL_0032:  /* 08   |                  */ ldloc.2
      IL_0033:  /* 28   | (2B)000002       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Cast<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>(class [mscorlib/*23000001*/]System.Collections.IEnumerable/*0100006C*/) /* 2B000002 */
      IL_0038:  /* 0E   | 04               */ ldarg.s    args
      IL_003a:  /* 0E   | 05               */ ldarg.s    'method'
      IL_003c:  /* 28   | (06)000059       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindBestMethod(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>,
                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                         class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000059 */
      IL_0041:  /* 0D   |                  */ stloc.3
      IL_0042:  /* 09   |                  */ ldloc.3
      IL_0043:  /* 2C   | 05               */ brfalse.s  IL_004a

      IL_0045:  /* 09   |                  */ ldloc.3
      IL_0046:  /* 13   | 04               */ stloc.s    V_4
      IL_0048:  /* DE   | 1D               */ leave.s    IL_0067

      IL_004a:  /* 11   | 05               */ ldloc.s    V_5
      IL_004c:  /* 6F   | (0A)000022       */ callvirt   instance bool [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext() /* 0A000022 */
      IL_0051:  /* 2D   | C7               */ brtrue.s   IL_001a

      IL_0053:  /* DE   | 0C               */ leave.s    IL_0061

    }  // end .try
    finally
    {
      IL_0055:  /* 11   | 05               */ ldloc.s    V_5
      IL_0057:  /* 2C   | 07               */ brfalse.s  IL_0060

      IL_0059:  /* 11   | 05               */ ldloc.s    V_5
      IL_005b:  /* 6F   | (0A)000023       */ callvirt   instance void [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose() /* 0A000023 */
      IL_0060:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 18 00 3D 55 00 0C 00 00 00 00
    IL_0061:  /* 0E   | 05               */ ldarg.s    'method'
    IL_0063:  /* 14   |                  */ ldnull
    IL_0064:  /* 51   |                  */ stind.ref
    IL_0065:  /* 16   |                  */ ldc.i4.0
    IL_0066:  /* 2A   |                  */ ret

    IL_0067:  /* 11   | 04               */ ldloc.s    V_4
    IL_0069:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::FindMethod

  .method /*06000055*/ private hidebysig 
          instance int32  FindIndexer(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                                      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args,
                                      [out] class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/& 'method') cil managed
  // SIG: 20 03 08 12 21 1D 12 25 10 12 59
  {
    // Method begins at RVA 0x4938
    // Code size       159 (0x9f)
    .maxstack  4
    .locals /*11000034*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] V_1,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> V_2,
             int32 V_3,
             int32 V_4,
             class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> V_5)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 28   | (06)000056       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::SelfAndBaseTypes(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000056 */
    IL_0006:  /* 6F   | (0A)0000B0       */ callvirt   instance class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<!0> class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000011*/::GetEnumerator() /* 0A0000B0 */
    IL_000b:  /* 13   | 05               */ stloc.s    V_5
    .try
    {
      IL_000d:  /* 2B   | 71               */ br.s       IL_0080

      IL_000f:  /* 11   | 05               */ ldloc.s    V_5
      IL_0011:  /* 6F   | (0A)0000B1       */ callvirt   instance !0 class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerator`1/*01000039*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000012*/::get_Current() /* 0A0000B1 */
      IL_0016:  /* 0A   |                  */ stloc.0
      IL_0017:  /* 06   |                  */ ldloc.0
      IL_0018:  /* 6F   | (0A)0000B8       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetDefaultMembers() /* 0A0000B8 */
      IL_001d:  /* 0B   |                  */ stloc.1
      IL_001e:  /* 07   |                  */ ldloc.1
      IL_001f:  /* 8E   |                  */ ldlen
      IL_0020:  /* 69   |                  */ conv.i4
      IL_0021:  /* 2C   | 5D               */ brfalse.s  IL_0080

      IL_0023:  /* 07   |                  */ ldloc.1
      IL_0024:  /* 28   | (2B)000003       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::OfType<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/>(class [mscorlib/*23000001*/]System.Collections.IEnumerable/*0100006C*/) /* 2B000003 */
      IL_0029:  /* 7E   | (04)00001E       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate3' /* 0400001E */
      IL_002e:  /* 2D   | 11               */ brtrue.s   IL_0041

      IL_0030:  /* 14   |                  */ ldnull
      IL_0031:  /* FE06 | (06)000077       */ ldftn      class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::'<FindIndexer>b__1'(class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/) /* 06000077 */
      IL_0037:  /* 73   | (0A)0000BA       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>/*1B000013*/::.ctor(object,
                                                                                                                                                                                                                                                                                             native int) /* 0A0000BA */
      IL_003c:  /* 80   | (04)00001E       */ stsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate3' /* 0400001E */
      IL_0041:  /* 7E   | (04)00001E       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate3' /* 0400001E */
      IL_0046:  /* 28   | (2B)000004       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!1> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Select<class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/,class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                                                                                                                                                                                class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,!!1>) /* 2B000004 */
      IL_004b:  /* 7E   | (04)00001F       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,bool> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate4' /* 0400001F */
      IL_0050:  /* 2D   | 11               */ brtrue.s   IL_0063

      IL_0052:  /* 14   |                  */ ldnull
      IL_0053:  /* FE06 | (06)000078       */ ldftn      bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::'<FindIndexer>b__2'(class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/) /* 06000078 */
      IL_0059:  /* 73   | (0A)0000BC       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,bool>/*1B000014*/::.ctor(object,
                                                                                                                                                                                                                           native int) /* 0A0000BC */
      IL_005e:  /* 80   | (04)00001F       */ stsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,bool> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate4' /* 0400001F */
      IL_0063:  /* 7E   | (04)00001F       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,bool> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegate4' /* 0400001F */
      IL_0068:  /* 28   | (2B)000005       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Where<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                                                                                                        class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,bool>) /* 2B000005 */
      IL_006d:  /* 0C   |                  */ stloc.2
      IL_006e:  /* 02   |                  */ ldarg.0
      IL_006f:  /* 08   |                  */ ldloc.2
      IL_0070:  /* 04   |                  */ ldarg.2
      IL_0071:  /* 05   |                  */ ldarg.3
      IL_0072:  /* 28   | (06)000059       */ call       instance int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::FindBestMethod(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/>,
                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[],
                                                                                                                                         class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/&) /* 06000059 */
      IL_0077:  /* 0D   |                  */ stloc.3
      IL_0078:  /* 09   |                  */ ldloc.3
      IL_0079:  /* 2C   | 05               */ brfalse.s  IL_0080

      IL_007b:  /* 09   |                  */ ldloc.3
      IL_007c:  /* 13   | 04               */ stloc.s    V_4
      IL_007e:  /* DE   | 1C               */ leave.s    IL_009c

      IL_0080:  /* 11   | 05               */ ldloc.s    V_5
      IL_0082:  /* 6F   | (0A)000022       */ callvirt   instance bool [mscorlib/*23000001*/]System.Collections.IEnumerator/*0100003A*/::MoveNext() /* 0A000022 */
      IL_0087:  /* 2D   | 86               */ brtrue.s   IL_000f

      IL_0089:  /* DE   | 0C               */ leave.s    IL_0097

    }  // end .try
    finally
    {
      IL_008b:  /* 11   | 05               */ ldloc.s    V_5
      IL_008d:  /* 2C   | 07               */ brfalse.s  IL_0096

      IL_008f:  /* 11   | 05               */ ldloc.s    V_5
      IL_0091:  /* 6F   | (0A)000023       */ callvirt   instance void [mscorlib/*23000001*/]System.IDisposable/*0100003B*/::Dispose() /* 0A000023 */
      IL_0096:  /* DC   |                  */ endfinally
    }  // end handler
    // HEX: 02 00 0D 00 7E 8B 00 0C 00 00 00 00
    IL_0097:  /* 05   |                  */ ldarg.3
    IL_0098:  /* 14   |                  */ ldnull
    IL_0099:  /* 51   |                  */ stind.ref
    IL_009a:  /* 16   |                  */ ldc.i4.0
    IL_009b:  /* 2A   |                  */ ret

    IL_009c:  /* 11   | 04               */ ldloc.s    V_4
    IL_009e:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::FindIndexer

  .method /*06000056*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> 
          SelfAndBaseTypes(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 15 12 39 01 12 21 12 21
  {
    // Method begins at RVA 0x49f4
    // Code size       30 (0x1e)
    .maxstack  2
    .locals /*11000035*/ init (class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 6F   | (0A)00009D       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsInterface() /* 0A00009D */
    IL_0006:  /* 2C   | 0F               */ brfalse.s  IL_0017

    IL_0008:  /* 73   | (0A)0000BE       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000015*/::.ctor() /* 0A0000BE */
    IL_000d:  /* 0A   |                  */ stloc.0
    IL_000e:  /* 06   |                  */ ldloc.0
    IL_000f:  /* 02   |                  */ ldarg.0
    IL_0010:  /* 28   | (06)000058       */ call       void System.Linq.Dynamic.ExpressionParser/*0200000A*/::AddInterface(class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>,
                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000058 */
    IL_0015:  /* 06   |                  */ ldloc.0
    IL_0016:  /* 2A   |                  */ ret

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 28   | (06)000057       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::SelfAndBaseClasses(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000057 */
    IL_001d:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::SelfAndBaseTypes

  .method /*06000057*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> 
          SelfAndBaseClasses(class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 01 15 12 39 01 12 21 12 21
  {
    // Method begins at RVA 0x4b14
    // Code size       17 (0x11)
    .maxstack  2
    .locals /*11000036*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/ V_0)
    IL_0000:  /* 1F   | FE               */ ldc.i4.s   -2
    IL_0002:  /* 73   | (06)0000CA       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::.ctor(int32) /* 060000CA */
    IL_0007:  /* 0A   |                  */ stloc.0
    IL_0008:  /* 06   |                  */ ldloc.0
    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 7D   | (04)000078       */ stfld      class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<SelfAndBaseClasses>d__5'/*02000018*/::'<>3__type' /* 04000078 */
    IL_000f:  /* 06   |                  */ ldloc.0
    IL_0010:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::SelfAndBaseClasses

  .method /*06000058*/ private hidebysig static 
          void  AddInterface(class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/> types,
                             class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 02 01 15 12 5D 01 12 21 12 21
  {
    // Method begins at RVA 0x4b34
    // Code size       49 (0x31)
    .maxstack  2
    .locals /*11000037*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_1,
             int32 V_2)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 6F   | (0A)0000C6       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000015*/::Contains(!0) /* 0A0000C6 */
    IL_0007:  /* 2D   | 27               */ brtrue.s   IL_0030

    IL_0009:  /* 02   |                  */ ldarg.0
    IL_000a:  /* 03   |                  */ ldarg.1
    IL_000b:  /* 6F   | (0A)0000C7       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>/*1B000015*/::Add(!0) /* 0A0000C7 */
    IL_0010:  /* 03   |                  */ ldarg.1
    IL_0011:  /* 6F   | (0A)0000A7       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::GetInterfaces() /* 0A0000A7 */
    IL_0016:  /* 0B   |                  */ stloc.1
    IL_0017:  /* 16   |                  */ ldc.i4.0
    IL_0018:  /* 0C   |                  */ stloc.2
    IL_0019:  /* 2B   | 0F               */ br.s       IL_002a

    IL_001b:  /* 07   |                  */ ldloc.1
    IL_001c:  /* 08   |                  */ ldloc.2
    IL_001d:  /* 9A   |                  */ ldelem.ref
    IL_001e:  /* 0A   |                  */ stloc.0
    IL_001f:  /* 02   |                  */ ldarg.0
    IL_0020:  /* 06   |                  */ ldloc.0
    IL_0021:  /* 28   | (06)000058       */ call       void System.Linq.Dynamic.ExpressionParser/*0200000A*/::AddInterface(class [mscorlib/*23000001*/]System.Collections.Generic.List`1/*01000017*/<class [mscorlib/*23000001*/]System.Type/*01000008*/>,
                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000058 */
    IL_0026:  /* 08   |                  */ ldloc.2
    IL_0027:  /* 17   |                  */ ldc.i4.1
    IL_0028:  /* 58   |                  */ add
    IL_0029:  /* 0C   |                  */ stloc.2
    IL_002a:  /* 08   |                  */ ldloc.2
    IL_002b:  /* 07   |                  */ ldloc.1
    IL_002c:  /* 8E   |                  */ ldlen
    IL_002d:  /* 69   |                  */ conv.i4
    IL_002e:  /* 32   | EB               */ blt.s      IL_001b

    IL_0030:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::AddInterface

  .method /*06000059*/ private hidebysig 
          instance int32  FindBestMethod(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/> methods,
                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args,
                                         [out] class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/& 'method') cil managed
  // SIG: 20 03 08 15 12 39 01 12 59 1D 12 25 10 12 59
  {
    // Method begins at RVA 0x4c1c
    // Code size       212 (0xd4)
    .maxstack  5
    .locals /*1100003A*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ V_0,
             int32 V_1,
             class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,bool> V_2,
             class System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/ V_3)
    IL_0000:  /* 14   |                  */ ldnull
    IL_0001:  /* 0C   |                  */ stloc.2
    IL_0002:  /* 73   | (06)0000CB       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::.ctor() /* 060000CB */
    IL_0007:  /* 0D   |                  */ stloc.3
    IL_0008:  /* 09   |                  */ ldloc.3
    IL_0009:  /* 04   |                  */ ldarg.2
    IL_000a:  /* 7D   | (04)00007B       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::args /* 0400007B */
    IL_000f:  /* 09   |                  */ ldloc.3
    IL_0010:  /* 02   |                  */ ldarg.0
    IL_0011:  /* 7D   | (04)00007A       */ stfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::'<>4__this' /* 0400007A */
    IL_0016:  /* 09   |                  */ ldloc.3
    IL_0017:  /* 03   |                  */ ldarg.1
    IL_0018:  /* 7E   | (04)000020       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegated' /* 04000020 */
    IL_001d:  /* 2D   | 11               */ brtrue.s   IL_0030

    IL_001f:  /* 14   |                  */ ldnull
    IL_0020:  /* FE06 | (06)000079       */ ldftn      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::'<FindBestMethod>b__9'(class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/) /* 06000079 */
    IL_0026:  /* 73   | (0A)0000CB       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>/*1B000017*/::.ctor(object,
                                                                                                                                                                                                                                                                                                  native int) /* 0A0000CB */
    IL_002b:  /* 80   | (04)000020       */ stsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegated' /* 04000020 */
    IL_0030:  /* 7E   | (04)000020       */ ldsfld     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/> System.Linq.Dynamic.ExpressionParser/*0200000A*/::'CS$<>9__CachedAnonymousMethodDelegated' /* 04000020 */
    IL_0035:  /* 28   | (2B)000007       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!1> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Select<class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                                                                                                                                                                                     class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,!!1>) /* 2B000007 */
    IL_003a:  /* 09   |                  */ ldloc.3
    IL_003b:  /* FE06 | (06)0000CC       */ ldftn      instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::'<FindBestMethod>b__a'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/) /* 060000CC */
    IL_0041:  /* 73   | (0A)0000C9       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,bool>/*1B000016*/::.ctor(object,
                                                                                                                                                                                                                                  native int) /* 0A0000C9 */
    IL_0046:  /* 28   | (2B)000008       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Where<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,bool>) /* 2B000008 */
    IL_004b:  /* 28   | (2B)000009       */ call       !!0[] [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::ToArray<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>) /* 2B000009 */
    IL_0050:  /* 7D   | (04)000079       */ stfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_0055:  /* 09   |                  */ ldloc.3
    IL_0056:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_005b:  /* 8E   |                  */ ldlen
    IL_005c:  /* 69   |                  */ conv.i4
    IL_005d:  /* 17   |                  */ ldc.i4.1
    IL_005e:  /* 31   | 27               */ ble.s      IL_0087

    IL_0060:  /* 09   |                  */ ldloc.3
    IL_0061:  /* 09   |                  */ ldloc.3
    IL_0062:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_0067:  /* 08   |                  */ ldloc.2
    IL_0068:  /* 2D   | 0D               */ brtrue.s   IL_0077

    IL_006a:  /* 09   |                  */ ldloc.3
    IL_006b:  /* FE06 | (06)0000CD       */ ldftn      instance bool System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::'<FindBestMethod>b__b'(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/) /* 060000CD */
    IL_0071:  /* 73   | (0A)0000C9       */ newobj     instance void class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/,bool>/*1B000016*/::.ctor(object,
                                                                                                                                                                                                                                  native int) /* 0A0000C9 */
    IL_0076:  /* 0C   |                  */ stloc.2
    IL_0077:  /* 08   |                  */ ldloc.2
    IL_0078:  /* 28   | (2B)000008       */ call       class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0> [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::Where<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>,
                                                                                                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Func`2/*0100000D*/<!!0,bool>) /* 2B000008 */
    IL_007d:  /* 28   | (2B)000009       */ call       !!0[] [System.Core/*23000002*/]System.Linq.Enumerable/*01000041*/::ToArray<class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/>(class [mscorlib/*23000001*/]System.Collections.Generic.IEnumerable`1/*0100000E*/<!!0>) /* 2B000009 */
    IL_0082:  /* 7D   | (04)000079       */ stfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_0087:  /* 09   |                  */ ldloc.3
    IL_0088:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_008d:  /* 8E   |                  */ ldlen
    IL_008e:  /* 69   |                  */ conv.i4
    IL_008f:  /* 17   |                  */ ldc.i4.1
    IL_0090:  /* 33   | 36               */ bne.un.s   IL_00c8

    IL_0092:  /* 09   |                  */ ldloc.3
    IL_0093:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_0098:  /* 16   |                  */ ldc.i4.0
    IL_0099:  /* 9A   |                  */ ldelem.ref
    IL_009a:  /* 0A   |                  */ stloc.0
    IL_009b:  /* 16   |                  */ ldc.i4.0
    IL_009c:  /* 0B   |                  */ stloc.1
    IL_009d:  /* 2B   | 14               */ br.s       IL_00b3

    IL_009f:  /* 09   |                  */ ldloc.3
    IL_00a0:  /* 7B   | (04)00007B       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::args /* 0400007B */
    IL_00a5:  /* 07   |                  */ ldloc.1
    IL_00a6:  /* 06   |                  */ ldloc.0
    IL_00a7:  /* 7B   | (04)000047       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Args /* 04000047 */
    IL_00ac:  /* 07   |                  */ ldloc.1
    IL_00ad:  /* 9A   |                  */ ldelem.ref
    IL_00ae:  /* A2   |                  */ stelem.ref
    IL_00af:  /* 07   |                  */ ldloc.1
    IL_00b0:  /* 17   |                  */ ldc.i4.1
    IL_00b1:  /* 58   |                  */ add
    IL_00b2:  /* 0B   |                  */ stloc.1
    IL_00b3:  /* 07   |                  */ ldloc.1
    IL_00b4:  /* 09   |                  */ ldloc.3
    IL_00b5:  /* 7B   | (04)00007B       */ ldfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::args /* 0400007B */
    IL_00ba:  /* 8E   |                  */ ldlen
    IL_00bb:  /* 69   |                  */ conv.i4
    IL_00bc:  /* 32   | E1               */ blt.s      IL_009f

    IL_00be:  /* 05   |                  */ ldarg.3
    IL_00bf:  /* 06   |                  */ ldloc.0
    IL_00c0:  /* 7B   | (04)000045       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::MethodBase /* 04000045 */
    IL_00c5:  /* 51   |                  */ stind.ref
    IL_00c6:  /* 2B   | 03               */ br.s       IL_00cb

    IL_00c8:  /* 05   |                  */ ldarg.3
    IL_00c9:  /* 14   |                  */ ldnull
    IL_00ca:  /* 51   |                  */ stind.ref
    IL_00cb:  /* 09   |                  */ ldloc.3
    IL_00cc:  /* 7B   | (04)000079       */ ldfld      class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//'<>c__DisplayClassf'/*02000019*/::applicable /* 04000079 */
    IL_00d1:  /* 8E   |                  */ ldlen
    IL_00d2:  /* 69   |                  */ conv.i4
    IL_00d3:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::FindBestMethod

  .method /*0600005A*/ private hidebysig 
          instance bool  IsApplicable(class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ 'method',
                                      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args) cil managed
  // SIG: 20 02 02 12 58 1D 12 25
  {
    // Method begins at RVA 0x4cfc
    // Code size       92 (0x5c)
    .maxstack  4
    .locals /*1100003B*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_0,
             int32 V_1,
             class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/ V_2,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ V_3)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 7B   | (04)000046       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Parameters /* 04000046 */
    IL_0006:  /* 8E   |                  */ ldlen
    IL_0007:  /* 69   |                  */ conv.i4
    IL_0008:  /* 04   |                  */ ldarg.2
    IL_0009:  /* 8E   |                  */ ldlen
    IL_000a:  /* 69   |                  */ conv.i4
    IL_000b:  /* 2E   | 02               */ beq.s      IL_000f

    IL_000d:  /* 16   |                  */ ldc.i4.0
    IL_000e:  /* 2A   |                  */ ret

    IL_000f:  /* 04   |                  */ ldarg.2
    IL_0010:  /* 8E   |                  */ ldlen
    IL_0011:  /* 69   |                  */ conv.i4
    IL_0012:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0017:  /* 0A   |                  */ stloc.0
    IL_0018:  /* 16   |                  */ ldc.i4.0
    IL_0019:  /* 0B   |                  */ stloc.1
    IL_001a:  /* 2B   | 31               */ br.s       IL_004d

    IL_001c:  /* 03   |                  */ ldarg.1
    IL_001d:  /* 7B   | (04)000046       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Parameters /* 04000046 */
    IL_0022:  /* 07   |                  */ ldloc.1
    IL_0023:  /* 9A   |                  */ ldelem.ref
    IL_0024:  /* 0C   |                  */ stloc.2
    IL_0025:  /* 08   |                  */ ldloc.2
    IL_0026:  /* 6F   | (0A)0000CC       */ callvirt   instance bool [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/::get_IsOut() /* 0A0000CC */
    IL_002b:  /* 2C   | 02               */ brfalse.s  IL_002f

    IL_002d:  /* 16   |                  */ ldc.i4.0
    IL_002e:  /* 2A   |                  */ ret

    IL_002f:  /* 02   |                  */ ldarg.0
    IL_0030:  /* 04   |                  */ ldarg.2
    IL_0031:  /* 07   |                  */ ldloc.1
    IL_0032:  /* 9A   |                  */ ldelem.ref
    IL_0033:  /* 08   |                  */ ldloc.2
    IL_0034:  /* 6F   | (0A)0000CD       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/::get_ParameterType() /* 0A0000CD */
    IL_0039:  /* 16   |                  */ ldc.i4.0
    IL_003a:  /* 28   | (06)00005B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                                                                                                  bool) /* 0600005B */
    IL_003f:  /* 0D   |                  */ stloc.3
    IL_0040:  /* 09   |                  */ ldloc.3
    IL_0041:  /* 2D   | 02               */ brtrue.s   IL_0045

    IL_0043:  /* 16   |                  */ ldc.i4.0
    IL_0044:  /* 2A   |                  */ ret

    IL_0045:  /* 06   |                  */ ldloc.0
    IL_0046:  /* 07   |                  */ ldloc.1
    IL_0047:  /* 09   |                  */ ldloc.3
    IL_0048:  /* A2   |                  */ stelem.ref
    IL_0049:  /* 07   |                  */ ldloc.1
    IL_004a:  /* 17   |                  */ ldc.i4.1
    IL_004b:  /* 58   |                  */ add
    IL_004c:  /* 0B   |                  */ stloc.1
    IL_004d:  /* 07   |                  */ ldloc.1
    IL_004e:  /* 04   |                  */ ldarg.2
    IL_004f:  /* 8E   |                  */ ldlen
    IL_0050:  /* 69   |                  */ conv.i4
    IL_0051:  /* 32   | C9               */ blt.s      IL_001c

    IL_0053:  /* 03   |                  */ ldarg.1
    IL_0054:  /* 06   |                  */ ldloc.0
    IL_0055:  /* 7D   | (04)000047       */ stfld      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Args /* 04000047 */
    IL_005a:  /* 17   |                  */ ldc.i4.1
    IL_005b:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsApplicable

  .method /*0600005B*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          PromoteExpression(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ expr,
                            class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type',
                            bool exact) cil managed
  // SIG: 20 03 12 25 12 25 12 21 02
  {
    // Method begins at RVA 0x4d64
    // Code size       256 (0x100)
    .maxstack  3
    .locals /*1100003C*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ V_0,
             string V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_2,
             object V_3,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_4)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* 04   |                  */ ldarg.2
    IL_0007:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_000c:  /* 2C   | 02               */ brfalse.s  IL_0010

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 2A   |                  */ ret

    IL_0010:  /* 03   |                  */ ldarg.1
    IL_0011:  /* 75   | (01)00003D       */ isinst     [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/
    IL_0016:  /* 39   | C0000000         */ brfalse    IL_00db

    IL_001b:  /* 03   |                  */ ldarg.1
    IL_001c:  /* 74   | (01)00003D       */ castclass  [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/
    IL_0021:  /* 0A   |                  */ stloc.0
    IL_0022:  /* 06   |                  */ ldloc.0
    IL_0023:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0028:  /* 33   | 1B               */ bne.un.s   IL_0045

    IL_002a:  /* 04   |                  */ ldarg.2
    IL_002b:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0030:  /* 2C   | 0B               */ brfalse.s  IL_003d

    IL_0032:  /* 04   |                  */ ldarg.2
    IL_0033:  /* 28   | (06)000048       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000048 */
    IL_0038:  /* 39   | 9E000000         */ brfalse    IL_00db

    IL_003d:  /* 14   |                  */ ldnull
    IL_003e:  /* 04   |                  */ ldarg.2
    IL_003f:  /* 28   | (0A)0000CE       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object,
                                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000CE */
    IL_0044:  /* 2A   |                  */ ret

    IL_0045:  /* 02   |                  */ ldarg.0
    IL_0046:  /* 7B   | (04)000017       */ ldfld      class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string> System.Linq.Dynamic.ExpressionParser/*0200000A*/::literals /* 04000017 */
    IL_004b:  /* 06   |                  */ ldloc.0
    IL_004c:  /* 12   | 01               */ ldloca.s   V_1
    IL_004e:  /* 6F   | (0A)0000CF       */ callvirt   instance bool class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,string>/*1B00000C*/::TryGetValue(!0,
                                                                                                                                                                                                                                                                    !1&) /* 0A0000CF */
    IL_0053:  /* 39   | 83000000         */ brfalse    IL_00db

    IL_0058:  /* 04   |                  */ ldarg.2
    IL_0059:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_005e:  /* 0C   |                  */ stloc.2
    IL_005f:  /* 14   |                  */ ldnull
    IL_0060:  /* 0D   |                  */ stloc.3
    IL_0061:  /* 06   |                  */ ldloc.0
    IL_0062:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0067:  /* 28   | (0A)0000AF       */ call       valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeCode(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000AF */
    IL_006c:  /* 13   | 04               */ stloc.s    V_4
    IL_006e:  /* 11   | 04               */ ldloc.s    V_4
    IL_0070:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0072:  /* 59   |                  */ sub
    IL_0073:  /* 45   | 0A000000         */ switch     ( 
              /*      | 02000000         */             IL_00a2,
              /*      | 02000000         */             IL_00a2,
              /*      | 02000000         */             IL_00a2,
              /*      | 02000000         */             IL_00a2,
              /*      | 30000000         */             IL_00d0,
              /*      | 0C000000         */             IL_00ac,
              /*      | 30000000         */             IL_00d0,
              /*      | 30000000         */             IL_00d0,
              /*      | 30000000         */             IL_00d0,
              /*      | 28000000         */             IL_00c8)
    IL_00a0:  /* 2B   | 2E               */ br.s       IL_00d0

    IL_00a2:  /* 07   |                  */ ldloc.1
    IL_00a3:  /* 08   |                  */ ldloc.2
    IL_00a4:  /* 28   | (06)00005C       */ call       object System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseNumber(string,
                                                                                                                            class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005C */
    IL_00a9:  /* 0D   |                  */ stloc.3
    IL_00aa:  /* 2B   | 24               */ br.s       IL_00d0

    IL_00ac:  /* 08   |                  */ ldloc.2
    IL_00ad:  /* D0   | (01)00001A       */ ldtoken    [mscorlib/*23000001*/]System.Decimal/*0100001A*/
    IL_00b2:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00b7:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_00bc:  /* 2C   | 12               */ brfalse.s  IL_00d0

    IL_00be:  /* 07   |                  */ ldloc.1
    IL_00bf:  /* 08   |                  */ ldloc.2
    IL_00c0:  /* 28   | (06)00005C       */ call       object System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseNumber(string,
                                                                                                                            class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005C */
    IL_00c5:  /* 0D   |                  */ stloc.3
    IL_00c6:  /* 2B   | 08               */ br.s       IL_00d0

    IL_00c8:  /* 07   |                  */ ldloc.1
    IL_00c9:  /* 08   |                  */ ldloc.2
    IL_00ca:  /* 28   | (06)00005D       */ call       object System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseEnum(string,
                                                                                                                          class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005D */
    IL_00cf:  /* 0D   |                  */ stloc.3
    IL_00d0:  /* 09   |                  */ ldloc.3
    IL_00d1:  /* 2C   | 08               */ brfalse.s  IL_00db

    IL_00d3:  /* 09   |                  */ ldloc.3
    IL_00d4:  /* 04   |                  */ ldarg.2
    IL_00d5:  /* 28   | (0A)0000CE       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object,
                                                                                                                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000CE */
    IL_00da:  /* 2A   |                  */ ret

    IL_00db:  /* 03   |                  */ ldarg.1
    IL_00dc:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_00e1:  /* 04   |                  */ ldarg.2
    IL_00e2:  /* 28   | (06)00005E       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsCompatibleWith(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005E */
    IL_00e7:  /* 2C   | 15               */ brfalse.s  IL_00fe

    IL_00e9:  /* 04   |                  */ ldarg.2
    IL_00ea:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_00ef:  /* 2D   | 03               */ brtrue.s   IL_00f4

    IL_00f1:  /* 05   |                  */ ldarg.3
    IL_00f2:  /* 2C   | 08               */ brfalse.s  IL_00fc

    IL_00f4:  /* 03   |                  */ ldarg.1
    IL_00f5:  /* 04   |                  */ ldarg.2
    IL_00f6:  /* 28   | (0A)00007B       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.UnaryExpression/*01000037*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Convert(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                           class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007B */
    IL_00fb:  /* 2A   |                  */ ret

    IL_00fc:  /* 03   |                  */ ldarg.1
    IL_00fd:  /* 2A   |                  */ ret

    IL_00fe:  /* 14   |                  */ ldnull
    IL_00ff:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::PromoteExpression

  .method /*0600005C*/ private hidebysig static 
          object  ParseNumber(string text,
                              class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 02 1C 0E 12 21
  {
    // Method begins at RVA 0x4e70
    // Code size       279 (0x117)
    .maxstack  2
    .locals /*1100003D*/ init (int8 V_0,
             uint8 V_1,
             int16 V_2,
             uint16 V_3,
             int32 V_4,
             uint32 V_5,
             int64 V_6,
             uint64 V_7,
             float32 V_8,
             float64 V_9,
             valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/ V_10,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_11)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0006:  /* 28   | (0A)0000AF       */ call       valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeCode(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000AF */
    IL_000b:  /* 13   | 0B               */ stloc.s    V_11
    IL_000d:  /* 11   | 0B               */ ldloc.s    V_11
    IL_000f:  /* 1B   |                  */ ldc.i4.5
    IL_0010:  /* 59   |                  */ sub
    IL_0011:  /* 45   | 0B000000         */ switch     ( 
              /*      | 05000000         */             IL_0047,
              /*      | 19000000         */             IL_005b,
              /*      | 2D000000         */             IL_006f,
              /*      | 41000000         */             IL_0083,
              /*      | 55000000         */             IL_0097,
              /*      | 67000000         */             IL_00a9,
              /*      | 79000000         */             IL_00bb,
              /*      | 8B000000         */             IL_00cd,
              /*      | 9D000000         */             IL_00df,
              /*      | AF000000         */             IL_00f1,
              /*      | C1000000         */             IL_0103)
    IL_0042:  /* 38   | CE000000         */ br         IL_0115

    IL_0047:  /* 02   |                  */ ldarg.0
    IL_0048:  /* 12   | 00               */ ldloca.s   V_0
    IL_004a:  /* 28   | (0A)0000D0       */ call       bool [mscorlib/*23000001*/]System.SByte/*01000071*/::TryParse(string,
                                                                                                                     int8&) /* 0A0000D0 */
    IL_004f:  /* 39   | C1000000         */ brfalse    IL_0115

    IL_0054:  /* 06   |                  */ ldloc.0
    IL_0055:  /* 8C   | (01)000071       */ box        [mscorlib/*23000001*/]System.SByte/*01000071*/
    IL_005a:  /* 2A   |                  */ ret

    IL_005b:  /* 02   |                  */ ldarg.0
    IL_005c:  /* 12   | 01               */ ldloca.s   V_1
    IL_005e:  /* 28   | (0A)0000D1       */ call       bool [mscorlib/*23000001*/]System.Byte/*01000072*/::TryParse(string,
                                                                                                                    uint8&) /* 0A0000D1 */
    IL_0063:  /* 39   | AD000000         */ brfalse    IL_0115

    IL_0068:  /* 07   |                  */ ldloc.1
    IL_0069:  /* 8C   | (01)000072       */ box        [mscorlib/*23000001*/]System.Byte/*01000072*/
    IL_006e:  /* 2A   |                  */ ret

    IL_006f:  /* 02   |                  */ ldarg.0
    IL_0070:  /* 12   | 02               */ ldloca.s   V_2
    IL_0072:  /* 28   | (0A)0000D2       */ call       bool [mscorlib/*23000001*/]System.Int16/*01000073*/::TryParse(string,
                                                                                                                     int16&) /* 0A0000D2 */
    IL_0077:  /* 39   | 99000000         */ brfalse    IL_0115

    IL_007c:  /* 08   |                  */ ldloc.2
    IL_007d:  /* 8C   | (01)000073       */ box        [mscorlib/*23000001*/]System.Int16/*01000073*/
    IL_0082:  /* 2A   |                  */ ret

    IL_0083:  /* 02   |                  */ ldarg.0
    IL_0084:  /* 12   | 03               */ ldloca.s   V_3
    IL_0086:  /* 28   | (0A)0000D3       */ call       bool [mscorlib/*23000001*/]System.UInt16/*01000074*/::TryParse(string,
                                                                                                                      uint16&) /* 0A0000D3 */
    IL_008b:  /* 39   | 85000000         */ brfalse    IL_0115

    IL_0090:  /* 09   |                  */ ldloc.3
    IL_0091:  /* 8C   | (01)000074       */ box        [mscorlib/*23000001*/]System.UInt16/*01000074*/
    IL_0096:  /* 2A   |                  */ ret

    IL_0097:  /* 02   |                  */ ldarg.0
    IL_0098:  /* 12   | 04               */ ldloca.s   V_4
    IL_009a:  /* 28   | (0A)0000D4       */ call       bool [mscorlib/*23000001*/]System.Int32/*0100003C*/::TryParse(string,
                                                                                                                     int32&) /* 0A0000D4 */
    IL_009f:  /* 2C   | 74               */ brfalse.s  IL_0115

    IL_00a1:  /* 11   | 04               */ ldloc.s    V_4
    IL_00a3:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_00a8:  /* 2A   |                  */ ret

    IL_00a9:  /* 02   |                  */ ldarg.0
    IL_00aa:  /* 12   | 05               */ ldloca.s   V_5
    IL_00ac:  /* 28   | (0A)0000D5       */ call       bool [mscorlib/*23000001*/]System.UInt32/*0100005C*/::TryParse(string,
                                                                                                                      uint32&) /* 0A0000D5 */
    IL_00b1:  /* 2C   | 62               */ brfalse.s  IL_0115

    IL_00b3:  /* 11   | 05               */ ldloc.s    V_5
    IL_00b5:  /* 8C   | (01)00005C       */ box        [mscorlib/*23000001*/]System.UInt32/*0100005C*/
    IL_00ba:  /* 2A   |                  */ ret

    IL_00bb:  /* 02   |                  */ ldarg.0
    IL_00bc:  /* 12   | 06               */ ldloca.s   V_6
    IL_00be:  /* 28   | (0A)000086       */ call       bool [mscorlib/*23000001*/]System.Int64/*0100005D*/::TryParse(string,
                                                                                                                     int64&) /* 0A000086 */
    IL_00c3:  /* 2C   | 50               */ brfalse.s  IL_0115

    IL_00c5:  /* 11   | 06               */ ldloc.s    V_6
    IL_00c7:  /* 8C   | (01)00005D       */ box        [mscorlib/*23000001*/]System.Int64/*0100005D*/
    IL_00cc:  /* 2A   |                  */ ret

    IL_00cd:  /* 02   |                  */ ldarg.0
    IL_00ce:  /* 12   | 07               */ ldloca.s   V_7
    IL_00d0:  /* 28   | (0A)000085       */ call       bool [mscorlib/*23000001*/]System.UInt64/*0100005B*/::TryParse(string,
                                                                                                                      uint64&) /* 0A000085 */
    IL_00d5:  /* 2C   | 3E               */ brfalse.s  IL_0115

    IL_00d7:  /* 11   | 07               */ ldloc.s    V_7
    IL_00d9:  /* 8C   | (01)00005B       */ box        [mscorlib/*23000001*/]System.UInt64/*0100005B*/
    IL_00de:  /* 2A   |                  */ ret

    IL_00df:  /* 02   |                  */ ldarg.0
    IL_00e0:  /* 12   | 08               */ ldloca.s   V_8
    IL_00e2:  /* 28   | (0A)000087       */ call       bool [mscorlib/*23000001*/]System.Single/*0100005E*/::TryParse(string,
                                                                                                                      float32&) /* 0A000087 */
    IL_00e7:  /* 2C   | 2C               */ brfalse.s  IL_0115

    IL_00e9:  /* 11   | 08               */ ldloc.s    V_8
    IL_00eb:  /* 8C   | (01)00005E       */ box        [mscorlib/*23000001*/]System.Single/*0100005E*/
    IL_00f0:  /* 2A   |                  */ ret

    IL_00f1:  /* 02   |                  */ ldarg.0
    IL_00f2:  /* 12   | 09               */ ldloca.s   V_9
    IL_00f4:  /* 28   | (0A)000088       */ call       bool [mscorlib/*23000001*/]System.Double/*0100005F*/::TryParse(string,
                                                                                                                      float64&) /* 0A000088 */
    IL_00f9:  /* 2C   | 1A               */ brfalse.s  IL_0115

    IL_00fb:  /* 11   | 09               */ ldloc.s    V_9
    IL_00fd:  /* 8C   | (01)00005F       */ box        [mscorlib/*23000001*/]System.Double/*0100005F*/
    IL_0102:  /* 2A   |                  */ ret

    IL_0103:  /* 02   |                  */ ldarg.0
    IL_0104:  /* 12   | 0A               */ ldloca.s   V_10
    IL_0106:  /* 28   | (0A)0000D6       */ call       bool [mscorlib/*23000001*/]System.Decimal/*0100001A*/::TryParse(string,
                                                                                                                       valuetype [mscorlib/*23000001*/]System.Decimal/*0100001A*/&) /* 0A0000D6 */
    IL_010b:  /* 2C   | 08               */ brfalse.s  IL_0115

    IL_010d:  /* 11   | 0A               */ ldloc.s    V_10
    IL_010f:  /* 8C   | (01)00001A       */ box        [mscorlib/*23000001*/]System.Decimal/*0100001A*/
    IL_0114:  /* 2A   |                  */ ret

    IL_0115:  /* 14   |                  */ ldnull
    IL_0116:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseNumber

  .method /*0600005D*/ private hidebysig static 
          object  ParseEnum(string name,
                            class [mscorlib/*23000001*/]System.Type/*01000008*/ 'type') cil managed
  // SIG: 00 02 1C 0E 12 21
  {
    // Method begins at RVA 0x4f94
    // Code size       46 (0x2e)
    .maxstack  5
    .locals /*1100003E*/ init (class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] V_0)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)0000AE       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsEnum() /* 0A0000AE */
    IL_0006:  /* 2C   | 24               */ brfalse.s  IL_002c

    IL_0008:  /* 03   |                  */ ldarg.1
    IL_0009:  /* 1A   |                  */ ldc.i4.4
    IL_000a:  /* 1F   | 1A               */ ldc.i4.s   26
    IL_000c:  /* 7E   | (0A)0000B2       */ ldsfld     class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/ [mscorlib/*23000001*/]System.Type/*01000008*/::FilterNameIgnoreCase /* 0A0000B2 */
    IL_0011:  /* 02   |                  */ ldarg.0
    IL_0012:  /* 6F   | (0A)0000B3       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/[] [mscorlib/*23000001*/]System.Type/*01000008*/::FindMembers(valuetype [mscorlib/*23000001*/]System.Reflection.MemberTypes/*0100006B*/,
                                                                                                                                                                                                  valuetype [mscorlib/*23000001*/]System.Reflection.BindingFlags/*0100003F*/,
                                                                                                                                                                                                  class [mscorlib/*23000001*/]System.Reflection.MemberFilter/*0100006A*/,
                                                                                                                                                                                                  object) /* 0A0000B3 */
    IL_0017:  /* 0A   |                  */ stloc.0
    IL_0018:  /* 06   |                  */ ldloc.0
    IL_0019:  /* 8E   |                  */ ldlen
    IL_001a:  /* 69   |                  */ conv.i4
    IL_001b:  /* 2C   | 0F               */ brfalse.s  IL_002c

    IL_001d:  /* 06   |                  */ ldloc.0
    IL_001e:  /* 16   |                  */ ldc.i4.0
    IL_001f:  /* 9A   |                  */ ldelem.ref
    IL_0020:  /* 74   | (01)000012       */ castclass  [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/
    IL_0025:  /* 14   |                  */ ldnull
    IL_0026:  /* 6F   | (0A)0000D7       */ callvirt   instance object [mscorlib/*23000001*/]System.Reflection.FieldInfo/*01000012*/::GetValue(object) /* 0A0000D7 */
    IL_002b:  /* 2A   |                  */ ret

    IL_002c:  /* 14   |                  */ ldnull
    IL_002d:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseEnum

  .method /*0600005E*/ private hidebysig static 
          bool  IsCompatibleWith(class [mscorlib/*23000001*/]System.Type/*01000008*/ source,
                                 class [mscorlib/*23000001*/]System.Type/*01000008*/ target) cil managed
  // SIG: 00 02 02 12 21 12 21
  {
    // Method begins at RVA 0x4fd0
    // Code size       575 (0x23f)
    .maxstack  2
    .locals /*1100003F*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/ V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_2,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_3,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_4,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_5,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_6,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_7,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_8,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_9,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_10,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_11,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_12,
             valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ V_13)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0007:  /* 2C   | 02               */ brfalse.s  IL_000b

    IL_0009:  /* 17   |                  */ ldc.i4.1
    IL_000a:  /* 2A   |                  */ ret

    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 6F   | (0A)000079       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsValueType() /* 0A000079 */
    IL_0011:  /* 2D   | 08               */ brtrue.s   IL_001b

    IL_0013:  /* 03   |                  */ ldarg.1
    IL_0014:  /* 02   |                  */ ldarg.0
    IL_0015:  /* 6F   | (0A)00007A       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::IsAssignableFrom(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00007A */
    IL_001a:  /* 2A   |                  */ ret

    IL_001b:  /* 02   |                  */ ldarg.0
    IL_001c:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0021:  /* 0A   |                  */ stloc.0
    IL_0022:  /* 03   |                  */ ldarg.1
    IL_0023:  /* 28   | (06)000049       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetNonNullableType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000049 */
    IL_0028:  /* 0B   |                  */ stloc.1
    IL_0029:  /* 06   |                  */ ldloc.0
    IL_002a:  /* 02   |                  */ ldarg.0
    IL_002b:  /* 28   | (0A)000035       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Inequality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                         class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A000035 */
    IL_0030:  /* 2C   | 0B               */ brfalse.s  IL_003d

    IL_0032:  /* 07   |                  */ ldloc.1
    IL_0033:  /* 03   |                  */ ldarg.1
    IL_0034:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0039:  /* 2C   | 02               */ brfalse.s  IL_003d

    IL_003b:  /* 16   |                  */ ldc.i4.0
    IL_003c:  /* 2A   |                  */ ret

    IL_003d:  /* 06   |                  */ ldloc.0
    IL_003e:  /* 6F   | (0A)0000AE       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsEnum() /* 0A0000AE */
    IL_0043:  /* 2D   | 08               */ brtrue.s   IL_004d

    IL_0045:  /* 06   |                  */ ldloc.0
    IL_0046:  /* 28   | (0A)0000AF       */ call       valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeCode(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000AF */
    IL_004b:  /* 2B   | 01               */ br.s       IL_004e

    IL_004d:  /* 17   |                  */ ldc.i4.1
    IL_004e:  /* 0C   |                  */ stloc.2
    IL_004f:  /* 07   |                  */ ldloc.1
    IL_0050:  /* 6F   | (0A)0000AE       */ callvirt   instance bool [mscorlib/*23000001*/]System.Type/*01000008*/::get_IsEnum() /* 0A0000AE */
    IL_0055:  /* 2D   | 08               */ brtrue.s   IL_005f

    IL_0057:  /* 07   |                  */ ldloc.1
    IL_0058:  /* 28   | (0A)0000AF       */ call       valuetype [mscorlib/*23000001*/]System.TypeCode/*01000069*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeCode(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A0000AF */
    IL_005d:  /* 2B   | 01               */ br.s       IL_0060

    IL_005f:  /* 17   |                  */ ldc.i4.1
    IL_0060:  /* 0D   |                  */ stloc.3
    IL_0061:  /* 08   |                  */ ldloc.2
    IL_0062:  /* 13   | 04               */ stloc.s    V_4
    IL_0064:  /* 11   | 04               */ ldloc.s    V_4
    IL_0066:  /* 1B   |                  */ ldc.i4.5
    IL_0067:  /* 59   |                  */ sub
    IL_0068:  /* 45   | 09000000         */ switch     ( 
              /*      | 05000000         */             IL_0096,
              /*      | 44000000         */             IL_00d5,
              /*      | 7F000000         */             IL_0110,
              /*      | B6000000         */             IL_0147,
              /*      | E9000000         */             IL_017a,
              /*      | 19010000         */             IL_01aa,
              /*      | 42010000         */             IL_01d3,
              /*      | 67010000         */             IL_01f8,
              /*      | 88010000         */             IL_0219)
    IL_0091:  /* 38   | 9C010000         */ br         IL_0232

    IL_0096:  /* 09   |                  */ ldloc.3
    IL_0097:  /* 13   | 05               */ stloc.s    V_5
    IL_0099:  /* 11   | 05               */ ldloc.s    V_5
    IL_009b:  /* 1B   |                  */ ldc.i4.5
    IL_009c:  /* 59   |                  */ sub
    IL_009d:  /* 45   | 0B000000         */ switch     ( 
              /*      | 05000000         */             IL_00d3,
              /*      | 6F010000         */             IL_023d,
              /*      | 05000000         */             IL_00d3,
              /*      | 6F010000         */             IL_023d,
              /*      | 05000000         */             IL_00d3,
              /*      | 6F010000         */             IL_023d,
              /*      | 05000000         */             IL_00d3,
              /*      | 6F010000         */             IL_023d,
              /*      | 05000000         */             IL_00d3,
              /*      | 05000000         */             IL_00d3,
              /*      | 05000000         */             IL_00d3)
    IL_00ce:  /* 38   | 6A010000         */ br         IL_023d

    IL_00d3:  /* 17   |                  */ ldc.i4.1
    IL_00d4:  /* 2A   |                  */ ret

    IL_00d5:  /* 09   |                  */ ldloc.3
    IL_00d6:  /* 13   | 06               */ stloc.s    V_6
    IL_00d8:  /* 11   | 06               */ ldloc.s    V_6
    IL_00da:  /* 1C   |                  */ ldc.i4.6
    IL_00db:  /* 59   |                  */ sub
    IL_00dc:  /* 45   | 0A000000         */ switch     ( 
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e,
              /*      | 05000000         */             IL_010e)
    IL_0109:  /* 38   | 2F010000         */ br         IL_023d

    IL_010e:  /* 17   |                  */ ldc.i4.1
    IL_010f:  /* 2A   |                  */ ret

    IL_0110:  /* 09   |                  */ ldloc.3
    IL_0111:  /* 13   | 07               */ stloc.s    V_7
    IL_0113:  /* 11   | 07               */ ldloc.s    V_7
    IL_0115:  /* 1D   |                  */ ldc.i4.7
    IL_0116:  /* 59   |                  */ sub
    IL_0117:  /* 45   | 09000000         */ switch     ( 
              /*      | 05000000         */             IL_0145,
              /*      | FD000000         */             IL_023d,
              /*      | 05000000         */             IL_0145,
              /*      | FD000000         */             IL_023d,
              /*      | 05000000         */             IL_0145,
              /*      | FD000000         */             IL_023d,
              /*      | 05000000         */             IL_0145,
              /*      | 05000000         */             IL_0145,
              /*      | 05000000         */             IL_0145)
    IL_0140:  /* 38   | F8000000         */ br         IL_023d

    IL_0145:  /* 17   |                  */ ldc.i4.1
    IL_0146:  /* 2A   |                  */ ret

    IL_0147:  /* 09   |                  */ ldloc.3
    IL_0148:  /* 13   | 08               */ stloc.s    V_8
    IL_014a:  /* 11   | 08               */ ldloc.s    V_8
    IL_014c:  /* 1E   |                  */ ldc.i4.8
    IL_014d:  /* 59   |                  */ sub
    IL_014e:  /* 45   | 08000000         */ switch     ( 
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178,
              /*      | 05000000         */             IL_0178)
    IL_0173:  /* 38   | C5000000         */ br         IL_023d

    IL_0178:  /* 17   |                  */ ldc.i4.1
    IL_0179:  /* 2A   |                  */ ret

    IL_017a:  /* 09   |                  */ ldloc.3
    IL_017b:  /* 13   | 09               */ stloc.s    V_9
    IL_017d:  /* 11   | 09               */ ldloc.s    V_9
    IL_017f:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0181:  /* 59   |                  */ sub
    IL_0182:  /* 45   | 07000000         */ switch     ( 
              /*      | 05000000         */             IL_01a8,
              /*      | 9A000000         */             IL_023d,
              /*      | 05000000         */             IL_01a8,
              /*      | 9A000000         */             IL_023d,
              /*      | 05000000         */             IL_01a8,
              /*      | 05000000         */             IL_01a8,
              /*      | 05000000         */             IL_01a8)
    IL_01a3:  /* 38   | 95000000         */ br         IL_023d

    IL_01a8:  /* 17   |                  */ ldc.i4.1
    IL_01a9:  /* 2A   |                  */ ret

    IL_01aa:  /* 09   |                  */ ldloc.3
    IL_01ab:  /* 13   | 0A               */ stloc.s    V_10
    IL_01ad:  /* 11   | 0A               */ ldloc.s    V_10
    IL_01af:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_01b1:  /* 59   |                  */ sub
    IL_01b2:  /* 45   | 06000000         */ switch     ( 
              /*      | 02000000         */             IL_01d1,
              /*      | 02000000         */             IL_01d1,
              /*      | 02000000         */             IL_01d1,
              /*      | 02000000         */             IL_01d1,
              /*      | 02000000         */             IL_01d1,
              /*      | 02000000         */             IL_01d1)
    IL_01cf:  /* 2B   | 6C               */ br.s       IL_023d

    IL_01d1:  /* 17   |                  */ ldc.i4.1
    IL_01d2:  /* 2A   |                  */ ret

    IL_01d3:  /* 09   |                  */ ldloc.3
    IL_01d4:  /* 13   | 0B               */ stloc.s    V_11
    IL_01d6:  /* 11   | 0B               */ ldloc.s    V_11
    IL_01d8:  /* 1F   | 0B               */ ldc.i4.s   11
    IL_01da:  /* 59   |                  */ sub
    IL_01db:  /* 45   | 05000000         */ switch     ( 
              /*      | 02000000         */             IL_01f6,
              /*      | 49000000         */             IL_023d,
              /*      | 02000000         */             IL_01f6,
              /*      | 02000000         */             IL_01f6,
              /*      | 02000000         */             IL_01f6)
    IL_01f4:  /* 2B   | 47               */ br.s       IL_023d

    IL_01f6:  /* 17   |                  */ ldc.i4.1
    IL_01f7:  /* 2A   |                  */ ret

    IL_01f8:  /* 09   |                  */ ldloc.3
    IL_01f9:  /* 13   | 0C               */ stloc.s    V_12
    IL_01fb:  /* 11   | 0C               */ ldloc.s    V_12
    IL_01fd:  /* 1F   | 0C               */ ldc.i4.s   12
    IL_01ff:  /* 59   |                  */ sub
    IL_0200:  /* 45   | 04000000         */ switch     ( 
              /*      | 02000000         */             IL_0217,
              /*      | 02000000         */             IL_0217,
              /*      | 02000000         */             IL_0217,
              /*      | 02000000         */             IL_0217)
    IL_0215:  /* 2B   | 26               */ br.s       IL_023d

    IL_0217:  /* 17   |                  */ ldc.i4.1
    IL_0218:  /* 2A   |                  */ ret

    IL_0219:  /* 09   |                  */ ldloc.3
    IL_021a:  /* 13   | 0D               */ stloc.s    V_13
    IL_021c:  /* 11   | 0D               */ ldloc.s    V_13
    IL_021e:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_0220:  /* 59   |                  */ sub
    IL_0221:  /* 45   | 02000000         */ switch     ( 
              /*      | 02000000         */             IL_0230,
              /*      | 02000000         */             IL_0230)
    IL_022e:  /* 2B   | 0D               */ br.s       IL_023d

    IL_0230:  /* 17   |                  */ ldc.i4.1
    IL_0231:  /* 2A   |                  */ ret

    IL_0232:  /* 06   |                  */ ldloc.0
    IL_0233:  /* 07   |                  */ ldloc.1
    IL_0234:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0239:  /* 2C   | 02               */ brfalse.s  IL_023d

    IL_023b:  /* 17   |                  */ ldc.i4.1
    IL_023c:  /* 2A   |                  */ ret

    IL_023d:  /* 16   |                  */ ldc.i4.0
    IL_023e:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsCompatibleWith

  .method /*0600005F*/ private hidebysig static 
          bool  IsBetterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] args,
                             class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ m1,
                             class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ m2) cil managed
  // SIG: 00 03 02 1D 12 25 12 58 12 58
  {
    // Method begins at RVA 0x521c
    // Code size       70 (0x46)
    .maxstack  4
    .locals /*11000040*/ init (bool V_0,
             int32 V_1,
             int32 V_2)
    IL_0000:  /* 16   |                  */ ldc.i4.0
    IL_0001:  /* 0A   |                  */ stloc.0
    IL_0002:  /* 16   |                  */ ldc.i4.0
    IL_0003:  /* 0B   |                  */ stloc.1
    IL_0004:  /* 2B   | 38               */ br.s       IL_003e

    IL_0006:  /* 02   |                  */ ldarg.0
    IL_0007:  /* 07   |                  */ ldloc.1
    IL_0008:  /* 9A   |                  */ ldelem.ref
    IL_0009:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 7B   | (04)000046       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Parameters /* 04000046 */
    IL_0014:  /* 07   |                  */ ldloc.1
    IL_0015:  /* 9A   |                  */ ldelem.ref
    IL_0016:  /* 6F   | (0A)0000CD       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/::get_ParameterType() /* 0A0000CD */
    IL_001b:  /* 04   |                  */ ldarg.2
    IL_001c:  /* 7B   | (04)000046       */ ldfld      class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Parameters /* 04000046 */
    IL_0021:  /* 07   |                  */ ldloc.1
    IL_0022:  /* 9A   |                  */ ldelem.ref
    IL_0023:  /* 6F   | (0A)0000CD       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/::get_ParameterType() /* 0A0000CD */
    IL_0028:  /* 28   | (06)000060       */ call       int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::CompareConversions(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                                  class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 06000060 */
    IL_002d:  /* 0C   |                  */ stloc.2
    IL_002e:  /* 08   |                  */ ldloc.2
    IL_002f:  /* 16   |                  */ ldc.i4.0
    IL_0030:  /* 2F   | 02               */ bge.s      IL_0034

    IL_0032:  /* 16   |                  */ ldc.i4.0
    IL_0033:  /* 2A   |                  */ ret

    IL_0034:  /* 08   |                  */ ldloc.2
    IL_0035:  /* 16   |                  */ ldc.i4.0
    IL_0036:  /* 31   | 02               */ ble.s      IL_003a

    IL_0038:  /* 17   |                  */ ldc.i4.1
    IL_0039:  /* 0A   |                  */ stloc.0
    IL_003a:  /* 07   |                  */ ldloc.1
    IL_003b:  /* 17   |                  */ ldc.i4.1
    IL_003c:  /* 58   |                  */ add
    IL_003d:  /* 0B   |                  */ stloc.1
    IL_003e:  /* 07   |                  */ ldloc.1
    IL_003f:  /* 02   |                  */ ldarg.0
    IL_0040:  /* 8E   |                  */ ldlen
    IL_0041:  /* 69   |                  */ conv.i4
    IL_0042:  /* 32   | C2               */ blt.s      IL_0006

    IL_0044:  /* 06   |                  */ ldloc.0
    IL_0045:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::IsBetterThan

  .method /*06000060*/ private hidebysig static 
          int32  CompareConversions(class [mscorlib/*23000001*/]System.Type/*01000008*/ s,
                                    class [mscorlib/*23000001*/]System.Type/*01000008*/ t1,
                                    class [mscorlib/*23000001*/]System.Type/*01000008*/ t2) cil managed
  // SIG: 00 03 08 12 21 12 21 12 21
  {
    // Method begins at RVA 0x5270
    // Code size       103 (0x67)
    .maxstack  2
    .locals /*11000041*/ init (bool V_0,
             bool V_1)
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 04   |                  */ ldarg.2
    IL_0002:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0007:  /* 2C   | 02               */ brfalse.s  IL_000b

    IL_0009:  /* 16   |                  */ ldc.i4.0
    IL_000a:  /* 2A   |                  */ ret

    IL_000b:  /* 02   |                  */ ldarg.0
    IL_000c:  /* 03   |                  */ ldarg.1
    IL_000d:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0012:  /* 2C   | 02               */ brfalse.s  IL_0016

    IL_0014:  /* 17   |                  */ ldc.i4.1
    IL_0015:  /* 2A   |                  */ ret

    IL_0016:  /* 02   |                  */ ldarg.0
    IL_0017:  /* 04   |                  */ ldarg.2
    IL_0018:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_001d:  /* 2C   | 02               */ brfalse.s  IL_0021

    IL_001f:  /* 15   |                  */ ldc.i4.m1
    IL_0020:  /* 2A   |                  */ ret

    IL_0021:  /* 03   |                  */ ldarg.1
    IL_0022:  /* 04   |                  */ ldarg.2
    IL_0023:  /* 28   | (06)00005E       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsCompatibleWith(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005E */
    IL_0028:  /* 0A   |                  */ stloc.0
    IL_0029:  /* 04   |                  */ ldarg.2
    IL_002a:  /* 03   |                  */ ldarg.1
    IL_002b:  /* 28   | (06)00005E       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsCompatibleWith(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                               class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600005E */
    IL_0030:  /* 0B   |                  */ stloc.1
    IL_0031:  /* 06   |                  */ ldloc.0
    IL_0032:  /* 2C   | 05               */ brfalse.s  IL_0039

    IL_0034:  /* 07   |                  */ ldloc.1
    IL_0035:  /* 2D   | 02               */ brtrue.s   IL_0039

    IL_0037:  /* 17   |                  */ ldc.i4.1
    IL_0038:  /* 2A   |                  */ ret

    IL_0039:  /* 07   |                  */ ldloc.1
    IL_003a:  /* 2C   | 05               */ brfalse.s  IL_0041

    IL_003c:  /* 06   |                  */ ldloc.0
    IL_003d:  /* 2D   | 02               */ brtrue.s   IL_0041

    IL_003f:  /* 15   |                  */ ldc.i4.m1
    IL_0040:  /* 2A   |                  */ ret

    IL_0041:  /* 03   |                  */ ldarg.1
    IL_0042:  /* 28   | (06)00004C       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsSignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004C */
    IL_0047:  /* 2C   | 0A               */ brfalse.s  IL_0053

    IL_0049:  /* 04   |                  */ ldarg.2
    IL_004a:  /* 28   | (06)00004D       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsUnsignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004D */
    IL_004f:  /* 2C   | 02               */ brfalse.s  IL_0053

    IL_0051:  /* 17   |                  */ ldc.i4.1
    IL_0052:  /* 2A   |                  */ ret

    IL_0053:  /* 04   |                  */ ldarg.2
    IL_0054:  /* 28   | (06)00004C       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsSignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004C */
    IL_0059:  /* 2C   | 0A               */ brfalse.s  IL_0065

    IL_005b:  /* 03   |                  */ ldarg.1
    IL_005c:  /* 28   | (06)00004D       */ call       bool System.Linq.Dynamic.ExpressionParser/*0200000A*/::IsUnsignedIntegralType(class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0600004D */
    IL_0061:  /* 2C   | 02               */ brfalse.s  IL_0065

    IL_0063:  /* 15   |                  */ ldc.i4.m1
    IL_0064:  /* 2A   |                  */ ret

    IL_0065:  /* 16   |                  */ ldc.i4.0
    IL_0066:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::CompareConversions

  .method /*06000061*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                        class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x52e3
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 04   |                  */ ldarg.2
    IL_0002:  /* 28   | (0A)0000D8       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Equal(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                          class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000D8 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateEqual

  .method /*06000062*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateNotEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x52ec
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 04   |                  */ ldarg.2
    IL_0002:  /* 28   | (0A)0000D9       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::NotEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000D9 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateNotEqual

  .method /*06000063*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateGreaterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                              class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x52f5
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 1E               */ brfalse.s  IL_0035

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 72   | (70)000DE9       */ ldstr      "Compare" /* 70000DE9 */
    IL_001d:  /* 03   |                  */ ldarg.1
    IL_001e:  /* 04   |                  */ ldarg.2
    IL_001f:  /* 28   | (06)00006B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStaticMethodCall(string,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006B */
    IL_0024:  /* 16   |                  */ ldc.i4.0
    IL_0025:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_002a:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_002f:  /* 28   | (0A)0000DA       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::GreaterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DA */
    IL_0034:  /* 2A   |                  */ ret

    IL_0035:  /* 03   |                  */ ldarg.1
    IL_0036:  /* 04   |                  */ ldarg.2
    IL_0037:  /* 28   | (0A)0000DA       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::GreaterThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DA */
    IL_003c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateGreaterThan

  .method /*06000064*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateGreaterThanEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x5333
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 1E               */ brfalse.s  IL_0035

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 72   | (70)000DE9       */ ldstr      "Compare" /* 70000DE9 */
    IL_001d:  /* 03   |                  */ ldarg.1
    IL_001e:  /* 04   |                  */ ldarg.2
    IL_001f:  /* 28   | (06)00006B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStaticMethodCall(string,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006B */
    IL_0024:  /* 16   |                  */ ldc.i4.0
    IL_0025:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_002a:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_002f:  /* 28   | (0A)0000DB       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::GreaterThanOrEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                       class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DB */
    IL_0034:  /* 2A   |                  */ ret

    IL_0035:  /* 03   |                  */ ldarg.1
    IL_0036:  /* 04   |                  */ ldarg.2
    IL_0037:  /* 28   | (0A)0000DB       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::GreaterThanOrEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                       class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DB */
    IL_003c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateGreaterThanEqual

  .method /*06000065*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateLessThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x5371
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 1E               */ brfalse.s  IL_0035

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 72   | (70)000DE9       */ ldstr      "Compare" /* 70000DE9 */
    IL_001d:  /* 03   |                  */ ldarg.1
    IL_001e:  /* 04   |                  */ ldarg.2
    IL_001f:  /* 28   | (06)00006B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStaticMethodCall(string,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006B */
    IL_0024:  /* 16   |                  */ ldc.i4.0
    IL_0025:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_002a:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_002f:  /* 28   | (0A)0000DC       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::LessThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DC */
    IL_0034:  /* 2A   |                  */ ret

    IL_0035:  /* 03   |                  */ ldarg.1
    IL_0036:  /* 04   |                  */ ldarg.2
    IL_0037:  /* 28   | (0A)0000DC       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::LessThan(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DC */
    IL_003c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateLessThan

  .method /*06000066*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateLessThanEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                                class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x53af
    // Code size       61 (0x3d)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 1E               */ brfalse.s  IL_0035

    IL_0017:  /* 02   |                  */ ldarg.0
    IL_0018:  /* 72   | (70)000DE9       */ ldstr      "Compare" /* 70000DE9 */
    IL_001d:  /* 03   |                  */ ldarg.1
    IL_001e:  /* 04   |                  */ ldarg.2
    IL_001f:  /* 28   | (06)00006B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStaticMethodCall(string,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006B */
    IL_0024:  /* 16   |                  */ ldc.i4.0
    IL_0025:  /* 8C   | (01)00003C       */ box        [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_002a:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_002f:  /* 28   | (0A)0000DD       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::LessThanOrEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DD */
    IL_0034:  /* 2A   |                  */ ret

    IL_0035:  /* 03   |                  */ ldarg.1
    IL_0036:  /* 04   |                  */ ldarg.2
    IL_0037:  /* 28   | (0A)0000DD       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::LessThanOrEqual(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                                    class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DD */
    IL_003c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateLessThanEqual

  .method /*06000067*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateAdd(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                      class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x53f0
    // Code size       68 (0x44)
    .maxstack  4
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_000b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0010:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_0015:  /* 2C   | 25               */ brfalse.s  IL_003c

    IL_0017:  /* 04   |                  */ ldarg.2
    IL_0018:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_001d:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_0022:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0027:  /* 28   | (0A)00002F       */ call       bool [mscorlib/*23000001*/]System.Type/*01000008*/::op_Equality(class [mscorlib/*23000001*/]System.Type/*01000008*/,
                                                                                                                       class [mscorlib/*23000001*/]System.Type/*01000008*/) /* 0A00002F */
    IL_002c:  /* 2C   | 0E               */ brfalse.s  IL_003c

    IL_002e:  /* 02   |                  */ ldarg.0
    IL_002f:  /* 72   | (70)000DF9       */ ldstr      "Concat" /* 70000DF9 */
    IL_0034:  /* 03   |                  */ ldarg.1
    IL_0035:  /* 04   |                  */ ldarg.2
    IL_0036:  /* 28   | (06)00006B       */ call       instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GenerateStaticMethodCall(string,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                         class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006B */
    IL_003b:  /* 2A   |                  */ ret

    IL_003c:  /* 03   |                  */ ldarg.1
    IL_003d:  /* 04   |                  */ ldarg.2
    IL_003e:  /* 28   | (0A)0000DE       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Add(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                        class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DE */
    IL_0043:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateAdd

  .method /*06000068*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateSubtract(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                           class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x5440
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 03   |                  */ ldarg.1
    IL_0001:  /* 04   |                  */ ldarg.2
    IL_0002:  /* 28   | (0A)0000DF       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.BinaryExpression/*01000059*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Subtract(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0A0000DF */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateSubtract

  .method /*06000069*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateStringConcat(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                               class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 02 12 25 12 25 12 25
  {
    // Method begins at RVA 0x544c
    // Code size       77 (0x4d)
    .maxstack  6
    .locals /*11000003*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0,
             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_1)
    IL_0000:  /* 14   |                  */ ldnull
    IL_0001:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_0006:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_000b:  /* 72   | (70)000DF9       */ ldstr      "Concat" /* 70000DF9 */
    IL_0010:  /* 18   |                  */ ldc.i4.2
    IL_0011:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0016:  /* 0A   |                  */ stloc.0
    IL_0017:  /* 06   |                  */ ldloc.0
    IL_0018:  /* 16   |                  */ ldc.i4.0
    IL_0019:  /* D0   | (01)000001       */ ldtoken    [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_001e:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0023:  /* A2   |                  */ stelem.ref
    IL_0024:  /* 06   |                  */ ldloc.0
    IL_0025:  /* 17   |                  */ ldc.i4.1
    IL_0026:  /* D0   | (01)000001       */ ldtoken    [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_002b:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0030:  /* A2   |                  */ stelem.ref
    IL_0031:  /* 06   |                  */ ldloc.0
    IL_0032:  /* 28   | (0A)000065       */ call       instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string,
                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000065 */
    IL_0037:  /* 18   |                  */ ldc.i4.2
    IL_0038:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_003d:  /* 0B   |                  */ stloc.1
    IL_003e:  /* 07   |                  */ ldloc.1
    IL_003f:  /* 16   |                  */ ldc.i4.0
    IL_0040:  /* 03   |                  */ ldarg.1
    IL_0041:  /* A2   |                  */ stelem.ref
    IL_0042:  /* 07   |                  */ ldloc.1
    IL_0043:  /* 17   |                  */ ldc.i4.1
    IL_0044:  /* 04   |                  */ ldarg.2
    IL_0045:  /* A2   |                  */ stelem.ref
    IL_0046:  /* 07   |                  */ ldloc.1
    IL_0047:  /* 28   | (0A)0000A1       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A0000A1 */
    IL_004c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateStringConcat

  .method /*0600006A*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ 
          GetStaticMethod(string methodName,
                          class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                          class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 03 12 61 0E 12 25 12 25
  {
    // Method begins at RVA 0x54a8
    // Code size       39 (0x27)
    .maxstack  5
    .locals /*11000042*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0)
    IL_0000:  /* 04   |                  */ ldarg.2
    IL_0001:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0006:  /* 03   |                  */ ldarg.1
    IL_0007:  /* 18   |                  */ ldc.i4.2
    IL_0008:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_000d:  /* 0A   |                  */ stloc.0
    IL_000e:  /* 06   |                  */ ldloc.0
    IL_000f:  /* 16   |                  */ ldc.i4.0
    IL_0010:  /* 04   |                  */ ldarg.2
    IL_0011:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_0016:  /* A2   |                  */ stelem.ref
    IL_0017:  /* 06   |                  */ ldloc.0
    IL_0018:  /* 17   |                  */ ldc.i4.1
    IL_0019:  /* 05   |                  */ ldarg.3
    IL_001a:  /* 6F   | (0A)00001D       */ callvirt   instance class [mscorlib/*23000001*/]System.Type/*01000008*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::get_Type() /* 0A00001D */
    IL_001f:  /* A2   |                  */ stelem.ref
    IL_0020:  /* 06   |                  */ ldloc.0
    IL_0021:  /* 6F   | (0A)000065       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetMethod(string,
                                                                                                                                                                                              class [mscorlib/*23000001*/]System.Type/*01000008*/[]) /* 0A000065 */
    IL_0026:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GetStaticMethod

  .method /*0600006B*/ private hidebysig 
          instance class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ 
          GenerateStaticMethodCall(string methodName,
                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ left,
                                   class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ right) cil managed
  // SIG: 20 03 12 25 0E 12 25 12 25
  {
    // Method begins at RVA 0x54dc
    // Code size       32 (0x20)
    .maxstack  5
    .locals /*1100002A*/ init (class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[] V_0)
    IL_0000:  /* 14   |                  */ ldnull
    IL_0001:  /* 02   |                  */ ldarg.0
    IL_0002:  /* 03   |                  */ ldarg.1
    IL_0003:  /* 04   |                  */ ldarg.2
    IL_0004:  /* 05   |                  */ ldarg.3
    IL_0005:  /* 28   | (06)00006A       */ call       instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::GetStaticMethod(string,
                                                                                                                                                                                                       class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                       class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/) /* 0600006A */
    IL_000a:  /* 18   |                  */ ldc.i4.2
    IL_000b:  /* 8D   | (01)000009       */ newarr     [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/
    IL_0010:  /* 0A   |                  */ stloc.0
    IL_0011:  /* 06   |                  */ ldloc.0
    IL_0012:  /* 16   |                  */ ldc.i4.0
    IL_0013:  /* 04   |                  */ ldarg.2
    IL_0014:  /* A2   |                  */ stelem.ref
    IL_0015:  /* 06   |                  */ ldloc.0
    IL_0016:  /* 17   |                  */ ldc.i4.1
    IL_0017:  /* 05   |                  */ ldarg.3
    IL_0018:  /* A2   |                  */ stelem.ref
    IL_0019:  /* 06   |                  */ ldloc.0
    IL_001a:  /* 28   | (0A)0000A1       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.MethodCallExpression/*01000038*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Call(class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/,
                                                                                                                                                                                                                             class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/,
                                                                                                                                                                                                                             class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/[]) /* 0A0000A1 */
    IL_001f:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GenerateStaticMethodCall

  .method /*0600006C*/ private hidebysig 
          instance void  SetTextPos(int32 pos) cil managed
  // SIG: 20 01 01 08
  {
    // Method begins at RVA 0x5508
    // Code size       48 (0x30)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 03   |                  */ ldarg.1
    IL_0002:  /* 7D   | (04)00001A       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_0014:  /* 32   | 03               */ blt.s      IL_0019

    IL_0016:  /* 16   |                  */ ldc.i4.0
    IL_0017:  /* 2B   | 11               */ br.s       IL_002a

    IL_0019:  /* 02   |                  */ ldarg.0
    IL_001a:  /* 7B   | (04)000019       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*/::text /* 04000019 */
    IL_001f:  /* 02   |                  */ ldarg.0
    IL_0020:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0025:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_002a:  /* 7D   | (04)00001C       */ stfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_002f:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::SetTextPos

  .method /*0600006D*/ private hidebysig 
          instance void  NextChar() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x553c
    // Code size       69 (0x45)
    .maxstack  4
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0006:  /* 02   |                  */ ldarg.0
    IL_0007:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_000c:  /* 2F   | 0E               */ bge.s      IL_001c

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 25   |                  */ dup
    IL_0010:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0015:  /* 17   |                  */ ldc.i4.1
    IL_0016:  /* 58   |                  */ add
    IL_0017:  /* 7D   | (04)00001A       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 02   |                  */ ldarg.0
    IL_001e:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0023:  /* 02   |                  */ ldarg.0
    IL_0024:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_0029:  /* 32   | 03               */ blt.s      IL_002e

    IL_002b:  /* 16   |                  */ ldc.i4.0
    IL_002c:  /* 2B   | 11               */ br.s       IL_003f

    IL_002e:  /* 02   |                  */ ldarg.0
    IL_002f:  /* 7B   | (04)000019       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*/::text /* 04000019 */
    IL_0034:  /* 02   |                  */ ldarg.0
    IL_0035:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_003a:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_003f:  /* 7D   | (04)00001C       */ stfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0044:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::NextChar

  .method /*0600006E*/ private hidebysig 
          instance void  NextToken() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x5590
    // Code size       1110 (0x456)
    .maxstack  6
    .locals /*11000043*/ init (valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ V_0,
             int32 V_1,
             char V_2,
             char V_3,
             object[] V_4)
    IL_0000:  /* 2B   | 06               */ br.s       IL_0008

    IL_0002:  /* 02   |                  */ ldarg.0
    IL_0003:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0008:  /* 02   |                  */ ldarg.0
    IL_0009:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_000e:  /* 28   | (0A)0000E0       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsWhiteSpace(char) /* 0A0000E0 */
    IL_0013:  /* 2D   | ED               */ brtrue.s   IL_0002

    IL_0015:  /* 02   |                  */ ldarg.0
    IL_0016:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_001b:  /* 0B   |                  */ stloc.1
    IL_001c:  /* 02   |                  */ ldarg.0
    IL_001d:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0022:  /* 0D   |                  */ stloc.3
    IL_0023:  /* 09   |                  */ ldloc.3
    IL_0024:  /* 1F   | 21               */ ldc.i4.s   33
    IL_0026:  /* 59   |                  */ sub
    IL_0027:  /* 45   | 1F000000         */ switch     ( 
              /*      | 22000000         */             IL_00ca,
              /*      | D1010000         */             IL_0279,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 47000000         */             IL_00ef,
              /*      | 54000000         */             IL_00fc,
              /*      | D1010000         */             IL_0279,
              /*      | 79000000         */             IL_0121,
              /*      | 87000000         */             IL_012f,
              /*      | 95000000         */             IL_013d,
              /*      | A3000000         */             IL_014b,
              /*      | B1000000         */             IL_0159,
              /*      | BF000000         */             IL_0167,
              /*      | CD000000         */             IL_0175,
              /*      | DB000000         */             IL_0183,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | 39020000         */             IL_02e1,
              /*      | E9000000         */             IL_0191,
              /*      | 39020000         */             IL_02e1,
              /*      | F7000000         */             IL_019f,
              /*      | 35010000         */             IL_01dd,
              /*      | 5B010000         */             IL_0203,
              /*      | 81010000         */             IL_0229)
    IL_00a8:  /* 09   |                  */ ldloc.3
    IL_00a9:  /* 1F   | 5B               */ ldc.i4.s   91
    IL_00ab:  /* 59   |                  */ sub
    IL_00ac:  /* 45   | 03000000         */ switch     ( 
              /*      | 7A010000         */             IL_0237,
              /*      | 24020000         */             IL_02e1,
              /*      | 88010000         */             IL_0245)
    IL_00bd:  /* 09   |                  */ ldloc.3
    IL_00be:  /* 1F   | 7C               */ ldc.i4.s   124
    IL_00c0:  /* 3B   | 8E010000         */ beq        IL_0253

    IL_00c5:  /* 38   | 17020000         */ br         IL_02e1

    IL_00ca:  /* 02   |                  */ ldarg.0
    IL_00cb:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_00d0:  /* 02   |                  */ ldarg.0
    IL_00d1:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_00d6:  /* 1F   | 3D               */ ldc.i4.s   61
    IL_00d8:  /* 33   | 0E               */ bne.un.s   IL_00e8

    IL_00da:  /* 02   |                  */ ldarg.0
    IL_00db:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_00e0:  /* 1F   | 19               */ ldc.i4.s   25
    IL_00e2:  /* 0A   |                  */ stloc.0
    IL_00e3:  /* 38   | 36030000         */ br         IL_041e

    IL_00e8:  /* 1C   |                  */ ldc.i4.6
    IL_00e9:  /* 0A   |                  */ stloc.0
    IL_00ea:  /* 38   | 2F030000         */ br         IL_041e

    IL_00ef:  /* 02   |                  */ ldarg.0
    IL_00f0:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_00f5:  /* 1D   |                  */ ldc.i4.7
    IL_00f6:  /* 0A   |                  */ stloc.0
    IL_00f7:  /* 38   | 22030000         */ br         IL_041e

    IL_00fc:  /* 02   |                  */ ldarg.0
    IL_00fd:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0102:  /* 02   |                  */ ldarg.0
    IL_0103:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0108:  /* 1F   | 26               */ ldc.i4.s   38
    IL_010a:  /* 33   | 0E               */ bne.un.s   IL_011a

    IL_010c:  /* 02   |                  */ ldarg.0
    IL_010d:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0112:  /* 1F   | 1A               */ ldc.i4.s   26
    IL_0114:  /* 0A   |                  */ stloc.0
    IL_0115:  /* 38   | 04030000         */ br         IL_041e

    IL_011a:  /* 1E   |                  */ ldc.i4.8
    IL_011b:  /* 0A   |                  */ stloc.0
    IL_011c:  /* 38   | FD020000         */ br         IL_041e

    IL_0121:  /* 02   |                  */ ldarg.0
    IL_0122:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0127:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0129:  /* 0A   |                  */ stloc.0
    IL_012a:  /* 38   | EF020000         */ br         IL_041e

    IL_012f:  /* 02   |                  */ ldarg.0
    IL_0130:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0135:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_0137:  /* 0A   |                  */ stloc.0
    IL_0138:  /* 38   | E1020000         */ br         IL_041e

    IL_013d:  /* 02   |                  */ ldarg.0
    IL_013e:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0143:  /* 1F   | 0B               */ ldc.i4.s   11
    IL_0145:  /* 0A   |                  */ stloc.0
    IL_0146:  /* 38   | D3020000         */ br         IL_041e

    IL_014b:  /* 02   |                  */ ldarg.0
    IL_014c:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0151:  /* 1F   | 0C               */ ldc.i4.s   12
    IL_0153:  /* 0A   |                  */ stloc.0
    IL_0154:  /* 38   | C5020000         */ br         IL_041e

    IL_0159:  /* 02   |                  */ ldarg.0
    IL_015a:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_015f:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_0161:  /* 0A   |                  */ stloc.0
    IL_0162:  /* 38   | B7020000         */ br         IL_041e

    IL_0167:  /* 02   |                  */ ldarg.0
    IL_0168:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_016d:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_016f:  /* 0A   |                  */ stloc.0
    IL_0170:  /* 38   | A9020000         */ br         IL_041e

    IL_0175:  /* 02   |                  */ ldarg.0
    IL_0176:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_017b:  /* 1F   | 0F               */ ldc.i4.s   15
    IL_017d:  /* 0A   |                  */ stloc.0
    IL_017e:  /* 38   | 9B020000         */ br         IL_041e

    IL_0183:  /* 02   |                  */ ldarg.0
    IL_0184:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0189:  /* 1F   | 10               */ ldc.i4.s   16
    IL_018b:  /* 0A   |                  */ stloc.0
    IL_018c:  /* 38   | 8D020000         */ br         IL_041e

    IL_0191:  /* 02   |                  */ ldarg.0
    IL_0192:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0197:  /* 1F   | 11               */ ldc.i4.s   17
    IL_0199:  /* 0A   |                  */ stloc.0
    IL_019a:  /* 38   | 7F020000         */ br         IL_041e

    IL_019f:  /* 02   |                  */ ldarg.0
    IL_01a0:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_01a5:  /* 02   |                  */ ldarg.0
    IL_01a6:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_01ab:  /* 1F   | 3D               */ ldc.i4.s   61
    IL_01ad:  /* 33   | 0E               */ bne.un.s   IL_01bd

    IL_01af:  /* 02   |                  */ ldarg.0
    IL_01b0:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_01b5:  /* 1F   | 1B               */ ldc.i4.s   27
    IL_01b7:  /* 0A   |                  */ stloc.0
    IL_01b8:  /* 38   | 61020000         */ br         IL_041e

    IL_01bd:  /* 02   |                  */ ldarg.0
    IL_01be:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_01c3:  /* 1F   | 3E               */ ldc.i4.s   62
    IL_01c5:  /* 33   | 0E               */ bne.un.s   IL_01d5

    IL_01c7:  /* 02   |                  */ ldarg.0
    IL_01c8:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_01cd:  /* 1F   | 1C               */ ldc.i4.s   28
    IL_01cf:  /* 0A   |                  */ stloc.0
    IL_01d0:  /* 38   | 49020000         */ br         IL_041e

    IL_01d5:  /* 1F   | 12               */ ldc.i4.s   18
    IL_01d7:  /* 0A   |                  */ stloc.0
    IL_01d8:  /* 38   | 41020000         */ br         IL_041e

    IL_01dd:  /* 02   |                  */ ldarg.0
    IL_01de:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_01e3:  /* 02   |                  */ ldarg.0
    IL_01e4:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_01e9:  /* 1F   | 3D               */ ldc.i4.s   61
    IL_01eb:  /* 33   | 0E               */ bne.un.s   IL_01fb

    IL_01ed:  /* 02   |                  */ ldarg.0
    IL_01ee:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_01f3:  /* 1F   | 1D               */ ldc.i4.s   29
    IL_01f5:  /* 0A   |                  */ stloc.0
    IL_01f6:  /* 38   | 23020000         */ br         IL_041e

    IL_01fb:  /* 1F   | 13               */ ldc.i4.s   19
    IL_01fd:  /* 0A   |                  */ stloc.0
    IL_01fe:  /* 38   | 1B020000         */ br         IL_041e

    IL_0203:  /* 02   |                  */ ldarg.0
    IL_0204:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0209:  /* 02   |                  */ ldarg.0
    IL_020a:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_020f:  /* 1F   | 3D               */ ldc.i4.s   61
    IL_0211:  /* 33   | 0E               */ bne.un.s   IL_0221

    IL_0213:  /* 02   |                  */ ldarg.0
    IL_0214:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0219:  /* 1F   | 1E               */ ldc.i4.s   30
    IL_021b:  /* 0A   |                  */ stloc.0
    IL_021c:  /* 38   | FD010000         */ br         IL_041e

    IL_0221:  /* 1F   | 14               */ ldc.i4.s   20
    IL_0223:  /* 0A   |                  */ stloc.0
    IL_0224:  /* 38   | F5010000         */ br         IL_041e

    IL_0229:  /* 02   |                  */ ldarg.0
    IL_022a:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_022f:  /* 1F   | 15               */ ldc.i4.s   21
    IL_0231:  /* 0A   |                  */ stloc.0
    IL_0232:  /* 38   | E7010000         */ br         IL_041e

    IL_0237:  /* 02   |                  */ ldarg.0
    IL_0238:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_023d:  /* 1F   | 16               */ ldc.i4.s   22
    IL_023f:  /* 0A   |                  */ stloc.0
    IL_0240:  /* 38   | D9010000         */ br         IL_041e

    IL_0245:  /* 02   |                  */ ldarg.0
    IL_0246:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_024b:  /* 1F   | 17               */ ldc.i4.s   23
    IL_024d:  /* 0A   |                  */ stloc.0
    IL_024e:  /* 38   | CB010000         */ br         IL_041e

    IL_0253:  /* 02   |                  */ ldarg.0
    IL_0254:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0259:  /* 02   |                  */ ldarg.0
    IL_025a:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_025f:  /* 1F   | 7C               */ ldc.i4.s   124
    IL_0261:  /* 33   | 0E               */ bne.un.s   IL_0271

    IL_0263:  /* 02   |                  */ ldarg.0
    IL_0264:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0269:  /* 1F   | 1F               */ ldc.i4.s   31
    IL_026b:  /* 0A   |                  */ stloc.0
    IL_026c:  /* 38   | AD010000         */ br         IL_041e

    IL_0271:  /* 1F   | 18               */ ldc.i4.s   24
    IL_0273:  /* 0A   |                  */ stloc.0
    IL_0274:  /* 38   | A5010000         */ br         IL_041e

    IL_0279:  /* 02   |                  */ ldarg.0
    IL_027a:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_027f:  /* 0C   |                  */ stloc.2
    IL_0280:  /* 02   |                  */ ldarg.0
    IL_0281:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0286:  /* 2B   | 06               */ br.s       IL_028e

    IL_0288:  /* 02   |                  */ ldarg.0
    IL_0289:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_028e:  /* 02   |                  */ ldarg.0
    IL_028f:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0294:  /* 02   |                  */ ldarg.0
    IL_0295:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_029a:  /* 2F   | 09               */ bge.s      IL_02a5

    IL_029c:  /* 02   |                  */ ldarg.0
    IL_029d:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_02a2:  /* 08   |                  */ ldloc.2
    IL_02a3:  /* 33   | E3               */ bne.un.s   IL_0288

    IL_02a5:  /* 02   |                  */ ldarg.0
    IL_02a6:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_02ab:  /* 02   |                  */ ldarg.0
    IL_02ac:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_02b1:  /* 33   | 18               */ bne.un.s   IL_02cb

    IL_02b3:  /* 02   |                  */ ldarg.0
    IL_02b4:  /* 02   |                  */ ldarg.0
    IL_02b5:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_02ba:  /* 72   | (70)000E07       */ ldstr      "Unterminated string literal" /* 70000E07 */
    IL_02bf:  /* 16   |                  */ ldc.i4.0
    IL_02c0:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_02c5:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_02ca:  /* 7A   |                  */ throw

    IL_02cb:  /* 02   |                  */ ldarg.0
    IL_02cc:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_02d1:  /* 02   |                  */ ldarg.0
    IL_02d2:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_02d7:  /* 08   |                  */ ldloc.2
    IL_02d8:  /* 2E   | A6               */ beq.s      IL_0280

    IL_02da:  /* 19   |                  */ ldc.i4.3
    IL_02db:  /* 0A   |                  */ stloc.0
    IL_02dc:  /* 38   | 3D010000         */ br         IL_041e

    IL_02e1:  /* 02   |                  */ ldarg.0
    IL_02e2:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_02e7:  /* 28   | (0A)0000E1       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsLetter(char) /* 0A0000E1 */
    IL_02ec:  /* 2D   | 14               */ brtrue.s   IL_0302

    IL_02ee:  /* 02   |                  */ ldarg.0
    IL_02ef:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_02f4:  /* 1F   | 40               */ ldc.i4.s   64
    IL_02f6:  /* 2E   | 0A               */ beq.s      IL_0302

    IL_02f8:  /* 02   |                  */ ldarg.0
    IL_02f9:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_02fe:  /* 1F   | 5F               */ ldc.i4.s   95
    IL_0300:  /* 33   | 24               */ bne.un.s   IL_0326

    IL_0302:  /* 02   |                  */ ldarg.0
    IL_0303:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0308:  /* 02   |                  */ ldarg.0
    IL_0309:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_030e:  /* 28   | (0A)0000E2       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsLetterOrDigit(char) /* 0A0000E2 */
    IL_0313:  /* 2D   | ED               */ brtrue.s   IL_0302

    IL_0315:  /* 02   |                  */ ldarg.0
    IL_0316:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_031b:  /* 1F   | 5F               */ ldc.i4.s   95
    IL_031d:  /* 2E   | E3               */ beq.s      IL_0302

    IL_031f:  /* 18   |                  */ ldc.i4.2
    IL_0320:  /* 0A   |                  */ stloc.0
    IL_0321:  /* 38   | F8000000         */ br         IL_041e

    IL_0326:  /* 02   |                  */ ldarg.0
    IL_0327:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_032c:  /* 28   | (0A)0000E3       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsDigit(char) /* 0A0000E3 */
    IL_0331:  /* 39   | AB000000         */ brfalse    IL_03e1

    IL_0336:  /* 1A   |                  */ ldc.i4.4
    IL_0337:  /* 0A   |                  */ stloc.0
    IL_0338:  /* 02   |                  */ ldarg.0
    IL_0339:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_033e:  /* 02   |                  */ ldarg.0
    IL_033f:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0344:  /* 28   | (0A)0000E3       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsDigit(char) /* 0A0000E3 */
    IL_0349:  /* 2D   | ED               */ brtrue.s   IL_0338

    IL_034b:  /* 02   |                  */ ldarg.0
    IL_034c:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0351:  /* 1F   | 2E               */ ldc.i4.s   46
    IL_0353:  /* 33   | 21               */ bne.un.s   IL_0376

    IL_0355:  /* 1B   |                  */ ldc.i4.5
    IL_0356:  /* 0A   |                  */ stloc.0
    IL_0357:  /* 02   |                  */ ldarg.0
    IL_0358:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_035d:  /* 02   |                  */ ldarg.0
    IL_035e:  /* 28   | (06)000071       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateDigit() /* 06000071 */
    IL_0363:  /* 02   |                  */ ldarg.0
    IL_0364:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0369:  /* 02   |                  */ ldarg.0
    IL_036a:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_036f:  /* 28   | (0A)0000E3       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsDigit(char) /* 0A0000E3 */
    IL_0374:  /* 2D   | ED               */ brtrue.s   IL_0363

    IL_0376:  /* 02   |                  */ ldarg.0
    IL_0377:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_037c:  /* 1F   | 45               */ ldc.i4.s   69
    IL_037e:  /* 2E   | 0A               */ beq.s      IL_038a

    IL_0380:  /* 02   |                  */ ldarg.0
    IL_0381:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0386:  /* 1F   | 65               */ ldc.i4.s   101
    IL_0388:  /* 33   | 3B               */ bne.un.s   IL_03c5

    IL_038a:  /* 1B   |                  */ ldc.i4.5
    IL_038b:  /* 0A   |                  */ stloc.0
    IL_038c:  /* 02   |                  */ ldarg.0
    IL_038d:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_0392:  /* 02   |                  */ ldarg.0
    IL_0393:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0398:  /* 1F   | 2B               */ ldc.i4.s   43
    IL_039a:  /* 2E   | 0A               */ beq.s      IL_03a6

    IL_039c:  /* 02   |                  */ ldarg.0
    IL_039d:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_03a2:  /* 1F   | 2D               */ ldc.i4.s   45
    IL_03a4:  /* 33   | 06               */ bne.un.s   IL_03ac

    IL_03a6:  /* 02   |                  */ ldarg.0
    IL_03a7:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_03ac:  /* 02   |                  */ ldarg.0
    IL_03ad:  /* 28   | (06)000071       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateDigit() /* 06000071 */
    IL_03b2:  /* 02   |                  */ ldarg.0
    IL_03b3:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_03b8:  /* 02   |                  */ ldarg.0
    IL_03b9:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_03be:  /* 28   | (0A)0000E3       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsDigit(char) /* 0A0000E3 */
    IL_03c3:  /* 2D   | ED               */ brtrue.s   IL_03b2

    IL_03c5:  /* 02   |                  */ ldarg.0
    IL_03c6:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_03cb:  /* 1F   | 46               */ ldc.i4.s   70
    IL_03cd:  /* 2E   | 0A               */ beq.s      IL_03d9

    IL_03cf:  /* 02   |                  */ ldarg.0
    IL_03d0:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_03d5:  /* 1F   | 66               */ ldc.i4.s   102
    IL_03d7:  /* 33   | 45               */ bne.un.s   IL_041e

    IL_03d9:  /* 02   |                  */ ldarg.0
    IL_03da:  /* 28   | (06)00006D       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::NextChar() /* 0600006D */
    IL_03df:  /* 2B   | 3D               */ br.s       IL_041e

    IL_03e1:  /* 02   |                  */ ldarg.0
    IL_03e2:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_03e7:  /* 02   |                  */ ldarg.0
    IL_03e8:  /* 7B   | (04)00001B       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textLen /* 0400001B */
    IL_03ed:  /* 33   | 04               */ bne.un.s   IL_03f3

    IL_03ef:  /* 17   |                  */ ldc.i4.1
    IL_03f0:  /* 0A   |                  */ stloc.0
    IL_03f1:  /* 2B   | 2B               */ br.s       IL_041e

    IL_03f3:  /* 02   |                  */ ldarg.0
    IL_03f4:  /* 02   |                  */ ldarg.0
    IL_03f5:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_03fa:  /* 72   | (70)000E3F       */ ldstr      "Syntax error '{0}'" /* 70000E3F */
    IL_03ff:  /* 17   |                  */ ldc.i4.1
    IL_0400:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0405:  /* 13   | 04               */ stloc.s    V_4
    IL_0407:  /* 11   | 04               */ ldloc.s    V_4
    IL_0409:  /* 16   |                  */ ldc.i4.0
    IL_040a:  /* 02   |                  */ ldarg.0
    IL_040b:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0410:  /* 8C   | (01)00005A       */ box        [mscorlib/*23000001*/]System.Char/*0100005A*/
    IL_0415:  /* A2   |                  */ stelem.ref
    IL_0416:  /* 11   | 04               */ ldloc.s    V_4
    IL_0418:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_041d:  /* 7A   |                  */ throw

    IL_041e:  /* 02   |                  */ ldarg.0
    IL_041f:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0424:  /* 06   |                  */ ldloc.0
    IL_0425:  /* 7D   | (04)000021       */ stfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_042a:  /* 02   |                  */ ldarg.0
    IL_042b:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0430:  /* 02   |                  */ ldarg.0
    IL_0431:  /* 7B   | (04)000019       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*/::text /* 04000019 */
    IL_0436:  /* 07   |                  */ ldloc.1
    IL_0437:  /* 02   |                  */ ldarg.0
    IL_0438:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_043d:  /* 07   |                  */ ldloc.1
    IL_043e:  /* 59   |                  */ sub
    IL_043f:  /* 6F   | (0A)000082       */ callvirt   instance string [mscorlib/*23000001*/]System.String/*01000042*/::Substring(int32,
                                                                                                                                  int32) /* 0A000082 */
    IL_0444:  /* 7D   | (04)000022       */ stfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0449:  /* 02   |                  */ ldarg.0
    IL_044a:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_044f:  /* 07   |                  */ ldloc.1
    IL_0450:  /* 7D   | (04)000023       */ stfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_0455:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::NextToken

  .method /*0600006F*/ private hidebysig 
          instance bool  TokenIdentifierIs(string id) cil managed
  // SIG: 20 01 02 0E
  {
    // Method begins at RVA 0x59f2
    // Code size       35 (0x23)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_000b:  /* 18   |                  */ ldc.i4.2
    IL_000c:  /* 33   | 13               */ bne.un.s   IL_0021

    IL_000e:  /* 03   |                  */ ldarg.1
    IL_000f:  /* 02   |                  */ ldarg.0
    IL_0010:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0015:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_001a:  /* 1B   |                  */ ldc.i4.5
    IL_001b:  /* 28   | (0A)0000E4       */ call       bool [mscorlib/*23000001*/]System.String/*01000042*/::Equals(string,
                                                                                                                    string,
                                                                                                                    valuetype [mscorlib/*23000001*/]System.StringComparison/*01000075*/) /* 0A0000E4 */
    IL_0020:  /* 2A   |                  */ ret

    IL_0021:  /* 16   |                  */ ldc.i4.0
    IL_0022:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::TokenIdentifierIs

  .method /*06000070*/ private hidebysig 
          instance string  GetIdentifier() cil managed
  // SIG: 20 00 0E
  {
    // Method begins at RVA 0x5a18
    // Code size       54 (0x36)
    .maxstack  3
    .locals /*11000044*/ init (string V_0)
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 18   |                  */ ldc.i4.2
    IL_0002:  /* 72   | (70)000E65       */ ldstr      "Identifier expected" /* 70000E65 */
    IL_0007:  /* 28   | (06)000072       */ call       instance void System.Linq.Dynamic.ExpressionParser/*0200000A*/::ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/,
                                                                                                                                     string) /* 06000072 */
    IL_000c:  /* 02   |                  */ ldarg.0
    IL_000d:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0012:  /* 7B   | (04)000022       */ ldfld      string System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::text /* 04000022 */
    IL_0017:  /* 0A   |                  */ stloc.0
    IL_0018:  /* 06   |                  */ ldloc.0
    IL_0019:  /* 6F   | (0A)00006E       */ callvirt   instance int32 [mscorlib/*23000001*/]System.String/*01000042*/::get_Length() /* 0A00006E */
    IL_001e:  /* 17   |                  */ ldc.i4.1
    IL_001f:  /* 31   | 13               */ ble.s      IL_0034

    IL_0021:  /* 06   |                  */ ldloc.0
    IL_0022:  /* 16   |                  */ ldc.i4.0
    IL_0023:  /* 6F   | (0A)000081       */ callvirt   instance char [mscorlib/*23000001*/]System.String/*01000042*/::get_Chars(int32) /* 0A000081 */
    IL_0028:  /* 1F   | 40               */ ldc.i4.s   64
    IL_002a:  /* 33   | 08               */ bne.un.s   IL_0034

    IL_002c:  /* 06   |                  */ ldloc.0
    IL_002d:  /* 17   |                  */ ldc.i4.1
    IL_002e:  /* 6F   | (0A)0000E5       */ callvirt   instance string [mscorlib/*23000001*/]System.String/*01000042*/::Substring(int32) /* 0A0000E5 */
    IL_0033:  /* 0A   |                  */ stloc.0
    IL_0034:  /* 06   |                  */ ldloc.0
    IL_0035:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::GetIdentifier

  .method /*06000071*/ private hidebysig 
          instance void  ValidateDigit() cil managed
  // SIG: 20 00 01
  {
    // Method begins at RVA 0x5a5a
    // Code size       38 (0x26)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7B   | (04)00001C       */ ldfld      char System.Linq.Dynamic.ExpressionParser/*0200000A*/::ch /* 0400001C */
    IL_0006:  /* 28   | (0A)0000E3       */ call       bool [mscorlib/*23000001*/]System.Char/*0100005A*/::IsDigit(char) /* 0A0000E3 */
    IL_000b:  /* 2D   | 18               */ brtrue.s   IL_0025

    IL_000d:  /* 02   |                  */ ldarg.0
    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 7B   | (04)00001A       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*/::textPos /* 0400001A */
    IL_0014:  /* 72   | (70)000E8D       */ ldstr      "Digit expected" /* 70000E8D */
    IL_0019:  /* 16   |                  */ ldc.i4.0
    IL_001a:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_001f:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0024:  /* 7A   |                  */ throw

    IL_0025:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ValidateDigit

  .method /*06000072*/ private hidebysig 
          instance void  ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ t,
                                       string errorMessage) cil managed
  // SIG: 20 02 01 11 30 0E
  {
    // Method begins at RVA 0x5a81
    // Code size       29 (0x1d)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 2E   | 0E               */ beq.s      IL_001c

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 04   |                  */ ldarg.2
    IL_0010:  /* 16   |                  */ ldc.i4.0
    IL_0011:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_0016:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_001b:  /* 7A   |                  */ throw

    IL_001c:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ValidateToken

  .method /*06000073*/ private hidebysig 
          instance void  ValidateToken(valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ t) cil managed
  // SIG: 20 01 01 11 30
  {
    // Method begins at RVA 0x5a9f
    // Code size       33 (0x21)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0006:  /* 7B   | (04)000021       */ ldfld      valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//TokenId/*0200000C*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::id /* 04000021 */
    IL_000b:  /* 03   |                  */ ldarg.1
    IL_000c:  /* 2E   | 12               */ beq.s      IL_0020

    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 72   | (70)0002DD       */ ldstr      "Syntax error" /* 700002DD */
    IL_0014:  /* 16   |                  */ ldc.i4.0
    IL_0015:  /* 8D   | (01)000001       */ newarr     [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_001a:  /* 28   | (06)000074       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(string,
                                                                                                                                                                                      object[]) /* 06000074 */
    IL_001f:  /* 7A   |                  */ throw

    IL_0020:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ValidateToken

  .method /*06000074*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ 
          ParseError(string format,
                     object[] args) cil managed
  // SIG: 20 02 12 0D 0E 1D 1C
  {
    .param [2]/*080000AB*/ 
    .custom /*0C00002E:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x5ac1
    // Code size       20 (0x14)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 02   |                  */ ldarg.0
    IL_0002:  /* 7C   | (04)00001D       */ ldflda     valuetype System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::token /* 0400001D */
    IL_0007:  /* 7B   | (04)000023       */ ldfld      int32 System.Linq.Dynamic.ExpressionParser/*0200000A*//Token/*0200000B*/::pos /* 04000023 */
    IL_000c:  /* 03   |                  */ ldarg.1
    IL_000d:  /* 04   |                  */ ldarg.2
    IL_000e:  /* 28   | (06)000075       */ call       instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::ParseError(int32,
                                                                                                                                                                                      string,
                                                                                                                                                                                      object[]) /* 06000075 */
    IL_0013:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseError

  .method /*06000075*/ private hidebysig 
          instance class [mscorlib/*23000001*/]System.Exception/*01000003*/ 
          ParseError(int32 pos,
                     string format,
                     object[] args) cil managed
  // SIG: 20 03 12 0D 08 0E 1D 1C
  {
    .param [3]/*080000AE*/ 
    .custom /*0C00002F:0A000001*/ instance void [mscorlib/*23000001*/]System.ParamArrayAttribute/*0100001E*/::.ctor() /* 0A000001 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x5ad6
    // Code size       19 (0x13)
    .maxstack  8
    IL_0000:  /* 28   | (0A)0000E6       */ call       class [mscorlib/*23000001*/]System.Globalization.CultureInfo/*01000057*/ [mscorlib/*23000001*/]System.Globalization.CultureInfo/*01000057*/::get_CurrentCulture() /* 0A0000E6 */
    IL_0005:  /* 04   |                  */ ldarg.2
    IL_0006:  /* 05   |                  */ ldarg.3
    IL_0007:  /* 28   | (0A)0000E7       */ call       string [mscorlib/*23000001*/]System.String/*01000042*/::Format(class [mscorlib/*23000001*/]System.IFormatProvider/*01000058*/,
                                                                                                                      string,
                                                                                                                      object[]) /* 0A0000E7 */
    IL_000c:  /* 03   |                  */ ldarg.1
    IL_000d:  /* 73   | (06)000022       */ newobj     instance void System.Linq.Dynamic.ParseException/*02000009*/::.ctor(string,
                                                                                                                           int32) /* 06000022 */
    IL_0012:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::ParseError

  .method /*06000076*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> 
          CreateKeywords() cil managed
  // SIG: 00 00 15 12 41 02 0E 1C
  {
    // Method begins at RVA 0x5aec
    // Code size       146 (0x92)
    .maxstack  3
    .locals /*11000045*/ init (class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object> V_0,
             class [mscorlib/*23000001*/]System.Type/*01000008*/ V_1,
             class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_2,
             int32 V_3)
    IL_0000:  /* 28   | (0A)00006B       */ call       class [mscorlib/*23000001*/]System.StringComparer/*01000055*/ [mscorlib/*23000001*/]System.StringComparer/*01000055*/::get_OrdinalIgnoreCase() /* 0A00006B */
    IL_0005:  /* 73   | (0A)00006C       */ newobj     instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::.ctor(class [mscorlib/*23000001*/]System.Collections.Generic.IEqualityComparer`1/*01000056*/<!0>) /* 0A00006C */
    IL_000a:  /* 0A   |                  */ stloc.0
    IL_000b:  /* 06   |                  */ ldloc.0
    IL_000c:  /* 72   | (70)000EAB       */ ldstr      "true" /* 70000EAB */
    IL_0011:  /* 7E   | (04)00000E       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::trueLiteral /* 0400000E */
    IL_0016:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_001b:  /* 06   |                  */ ldloc.0
    IL_001c:  /* 72   | (70)000EB5       */ ldstr      "false" /* 70000EB5 */
    IL_0021:  /* 7E   | (04)00000F       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::falseLiteral /* 0400000F */
    IL_0026:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_002b:  /* 06   |                  */ ldloc.0
    IL_002c:  /* 72   | (70)0005CF       */ ldstr      "null" /* 700005CF */
    IL_0031:  /* 7E   | (04)000010       */ ldsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0036:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_003b:  /* 06   |                  */ ldloc.0
    IL_003c:  /* 7E   | (04)000011       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIt /* 04000011 */
    IL_0041:  /* 7E   | (04)000011       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIt /* 04000011 */
    IL_0046:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_004b:  /* 06   |                  */ ldloc.0
    IL_004c:  /* 7E   | (04)000012       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIif /* 04000012 */
    IL_0051:  /* 7E   | (04)000012       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIif /* 04000012 */
    IL_0056:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_005b:  /* 06   |                  */ ldloc.0
    IL_005c:  /* 7E   | (04)000013       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordNew /* 04000013 */
    IL_0061:  /* 7E   | (04)000013       */ ldsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordNew /* 04000013 */
    IL_0066:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_006b:  /* 7E   | (04)00000D       */ ldsfld     class [mscorlib/*23000001*/]System.Type/*01000008*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::predefinedTypes /* 0400000D */
    IL_0070:  /* 0C   |                  */ stloc.2
    IL_0071:  /* 16   |                  */ ldc.i4.0
    IL_0072:  /* 0D   |                  */ stloc.3
    IL_0073:  /* 2B   | 15               */ br.s       IL_008a

    IL_0075:  /* 08   |                  */ ldloc.2
    IL_0076:  /* 09   |                  */ ldloc.3
    IL_0077:  /* 9A   |                  */ ldelem.ref
    IL_0078:  /* 0B   |                  */ stloc.1
    IL_0079:  /* 06   |                  */ ldloc.0
    IL_007a:  /* 07   |                  */ ldloc.1
    IL_007b:  /* 6F   | (0A)00002A       */ callvirt   instance string [mscorlib/*23000001*/]System.Reflection.MemberInfo/*01000015*/::get_Name() /* 0A00002A */
    IL_0080:  /* 07   |                  */ ldloc.1
    IL_0081:  /* 6F   | (0A)000074       */ callvirt   instance void class [mscorlib/*23000001*/]System.Collections.Generic.Dictionary`2/*01000010*/<string,object>/*1B00000B*/::Add(!0,
                                                                                                                                                                                     !1) /* 0A000074 */
    IL_0086:  /* 09   |                  */ ldloc.3
    IL_0087:  /* 17   |                  */ ldc.i4.1
    IL_0088:  /* 58   |                  */ add
    IL_0089:  /* 0D   |                  */ stloc.3
    IL_008a:  /* 09   |                  */ ldloc.3
    IL_008b:  /* 08   |                  */ ldloc.2
    IL_008c:  /* 8E   |                  */ ldlen
    IL_008d:  /* 69   |                  */ conv.i4
    IL_008e:  /* 32   | E5               */ blt.s      IL_0075

    IL_0090:  /* 06   |                  */ ldloc.0
    IL_0091:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::CreateKeywords

  .method /*06000077*/ private hidebysig static 
          class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ 
          '<FindIndexer>b__1'(class [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/ p) cil managed
  // SIG: 00 01 12 59 12 80 F9
  {
    .custom /*0C00002B:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x4924
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 6F   | (0A)0000B6       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.MethodInfo/*01000018*/ [mscorlib/*23000001*/]System.Reflection.PropertyInfo/*0100003E*/::GetGetMethod() /* 0A0000B6 */
    IL_0006:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::'<FindIndexer>b__1'

  .method /*06000078*/ private hidebysig static 
          bool  '<FindIndexer>b__2'(class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ m) cil managed
  // SIG: 00 01 02 12 59
  {
    .custom /*0C00002C:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x492c
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  /* 02   |                  */ ldarg.0
    IL_0001:  /* 14   |                  */ ldnull
    IL_0002:  /* 28   | (0A)0000B7       */ call       bool [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/::op_Inequality(class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/,
                                                                                                                                          class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/) /* 0A0000B7 */
    IL_0007:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::'<FindIndexer>b__2'

  .method /*06000079*/ private hidebysig static 
          class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ 
          '<FindBestMethod>b__9'(class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ m) cil managed
  // SIG: 00 01 12 58 12 59
  {
    .custom /*0C00002D:0A0000B5*/ instance void [mscorlib/*23000001*/]System.Runtime.CompilerServices.CompilerGeneratedAttribute/*0100006D*/::.ctor() /* 0A0000B5 */ = ( 01 00 00 00 ) 
    // Method begins at RVA 0x4b7c
    // Code size       27 (0x1b)
    .maxstack  2
    .locals /*11000038*/ init (class System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/ V_0)
    IL_0000:  /* 73   | (06)0000C2       */ newobj     instance void System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::.ctor() /* 060000C2 */
    IL_0005:  /* 0A   |                  */ stloc.0
    IL_0006:  /* 06   |                  */ ldloc.0
    IL_0007:  /* 02   |                  */ ldarg.0
    IL_0008:  /* 7D   | (04)000045       */ stfld      class [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/ System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::MethodBase /* 04000045 */
    IL_000d:  /* 06   |                  */ ldloc.0
    IL_000e:  /* 02   |                  */ ldarg.0
    IL_000f:  /* 6F   | (0A)0000C8       */ callvirt   instance class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] [mscorlib/*23000001*/]System.Reflection.MethodBase/*01000016*/::GetParameters() /* 0A0000C8 */
    IL_0014:  /* 7D   | (04)000046       */ stfld      class [mscorlib/*23000001*/]System.Reflection.ParameterInfo/*0100001D*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*//MethodData/*02000016*/::Parameters /* 04000046 */
    IL_0019:  /* 06   |                  */ ldloc.0
    IL_001a:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::'<FindBestMethod>b__9'

  .method /*0600007A*/ private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  // SIG: 00 00 01
  {
    // Method begins at RVA 0x5b8c
    // Code size       359 (0x167)
    .maxstack  3
    .locals /*11000042*/ init (class [mscorlib/*23000001*/]System.Type/*01000008*/[] V_0)
    IL_0000:  /* 1F   | 14               */ ldc.i4.s   20
    IL_0002:  /* 8D   | (01)000008       */ newarr     [mscorlib/*23000001*/]System.Type/*01000008*/
    IL_0007:  /* 0A   |                  */ stloc.0
    IL_0008:  /* 06   |                  */ ldloc.0
    IL_0009:  /* 16   |                  */ ldc.i4.0
    IL_000a:  /* D0   | (01)000001       */ ldtoken    [mscorlib/*23000001*/]System.Object/*01000001*/
    IL_000f:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0014:  /* A2   |                  */ stelem.ref
    IL_0015:  /* 06   |                  */ ldloc.0
    IL_0016:  /* 17   |                  */ ldc.i4.1
    IL_0017:  /* D0   | (01)000033       */ ldtoken    [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_001c:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0021:  /* A2   |                  */ stelem.ref
    IL_0022:  /* 06   |                  */ ldloc.0
    IL_0023:  /* 18   |                  */ ldc.i4.2
    IL_0024:  /* D0   | (01)00005A       */ ldtoken    [mscorlib/*23000001*/]System.Char/*0100005A*/
    IL_0029:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_002e:  /* A2   |                  */ stelem.ref
    IL_002f:  /* 06   |                  */ ldloc.0
    IL_0030:  /* 19   |                  */ ldc.i4.3
    IL_0031:  /* D0   | (01)000042       */ ldtoken    [mscorlib/*23000001*/]System.String/*01000042*/
    IL_0036:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_003b:  /* A2   |                  */ stelem.ref
    IL_003c:  /* 06   |                  */ ldloc.0
    IL_003d:  /* 1A   |                  */ ldc.i4.4
    IL_003e:  /* D0   | (01)000071       */ ldtoken    [mscorlib/*23000001*/]System.SByte/*01000071*/
    IL_0043:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0048:  /* A2   |                  */ stelem.ref
    IL_0049:  /* 06   |                  */ ldloc.0
    IL_004a:  /* 1B   |                  */ ldc.i4.5
    IL_004b:  /* D0   | (01)000072       */ ldtoken    [mscorlib/*23000001*/]System.Byte/*01000072*/
    IL_0050:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0055:  /* A2   |                  */ stelem.ref
    IL_0056:  /* 06   |                  */ ldloc.0
    IL_0057:  /* 1C   |                  */ ldc.i4.6
    IL_0058:  /* D0   | (01)000073       */ ldtoken    [mscorlib/*23000001*/]System.Int16/*01000073*/
    IL_005d:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0062:  /* A2   |                  */ stelem.ref
    IL_0063:  /* 06   |                  */ ldloc.0
    IL_0064:  /* 1D   |                  */ ldc.i4.7
    IL_0065:  /* D0   | (01)000074       */ ldtoken    [mscorlib/*23000001*/]System.UInt16/*01000074*/
    IL_006a:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_006f:  /* A2   |                  */ stelem.ref
    IL_0070:  /* 06   |                  */ ldloc.0
    IL_0071:  /* 1E   |                  */ ldc.i4.8
    IL_0072:  /* D0   | (01)00003C       */ ldtoken    [mscorlib/*23000001*/]System.Int32/*0100003C*/
    IL_0077:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_007c:  /* A2   |                  */ stelem.ref
    IL_007d:  /* 06   |                  */ ldloc.0
    IL_007e:  /* 1F   | 09               */ ldc.i4.s   9
    IL_0080:  /* D0   | (01)00005C       */ ldtoken    [mscorlib/*23000001*/]System.UInt32/*0100005C*/
    IL_0085:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_008a:  /* A2   |                  */ stelem.ref
    IL_008b:  /* 06   |                  */ ldloc.0
    IL_008c:  /* 1F   | 0A               */ ldc.i4.s   10
    IL_008e:  /* D0   | (01)00005D       */ ldtoken    [mscorlib/*23000001*/]System.Int64/*0100005D*/
    IL_0093:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0098:  /* A2   |                  */ stelem.ref
    IL_0099:  /* 06   |                  */ ldloc.0
    IL_009a:  /* 1F   | 0B               */ ldc.i4.s   11
    IL_009c:  /* D0   | (01)00005B       */ ldtoken    [mscorlib/*23000001*/]System.UInt64/*0100005B*/
    IL_00a1:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00a6:  /* A2   |                  */ stelem.ref
    IL_00a7:  /* 06   |                  */ ldloc.0
    IL_00a8:  /* 1F   | 0C               */ ldc.i4.s   12
    IL_00aa:  /* D0   | (01)00005E       */ ldtoken    [mscorlib/*23000001*/]System.Single/*0100005E*/
    IL_00af:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00b4:  /* A2   |                  */ stelem.ref
    IL_00b5:  /* 06   |                  */ ldloc.0
    IL_00b6:  /* 1F   | 0D               */ ldc.i4.s   13
    IL_00b8:  /* D0   | (01)00005F       */ ldtoken    [mscorlib/*23000001*/]System.Double/*0100005F*/
    IL_00bd:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00c2:  /* A2   |                  */ stelem.ref
    IL_00c3:  /* 06   |                  */ ldloc.0
    IL_00c4:  /* 1F   | 0E               */ ldc.i4.s   14
    IL_00c6:  /* D0   | (01)00001A       */ ldtoken    [mscorlib/*23000001*/]System.Decimal/*0100001A*/
    IL_00cb:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00d0:  /* A2   |                  */ stelem.ref
    IL_00d1:  /* 06   |                  */ ldloc.0
    IL_00d2:  /* 1F   | 0F               */ ldc.i4.s   15
    IL_00d4:  /* D0   | (01)00001B       */ ldtoken    [mscorlib/*23000001*/]System.DateTime/*0100001B*/
    IL_00d9:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00de:  /* A2   |                  */ stelem.ref
    IL_00df:  /* 06   |                  */ ldloc.0
    IL_00e0:  /* 1F   | 10               */ ldc.i4.s   16
    IL_00e2:  /* D0   | (01)00001C       */ ldtoken    [mscorlib/*23000001*/]System.TimeSpan/*0100001C*/
    IL_00e7:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00ec:  /* A2   |                  */ stelem.ref
    IL_00ed:  /* 06   |                  */ ldloc.0
    IL_00ee:  /* 1F   | 11               */ ldc.i4.s   17
    IL_00f0:  /* D0   | (01)000076       */ ldtoken    [mscorlib/*23000001*/]System.Guid/*01000076*/
    IL_00f5:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_00fa:  /* A2   |                  */ stelem.ref
    IL_00fb:  /* 06   |                  */ ldloc.0
    IL_00fc:  /* 1F   | 12               */ ldc.i4.s   18
    IL_00fe:  /* D0   | (01)000077       */ ldtoken    [mscorlib/*23000001*/]System.Math/*01000077*/
    IL_0103:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0108:  /* A2   |                  */ stelem.ref
    IL_0109:  /* 06   |                  */ ldloc.0
    IL_010a:  /* 1F   | 13               */ ldc.i4.s   19
    IL_010c:  /* D0   | (01)000078       */ ldtoken    [mscorlib/*23000001*/]System.Convert/*01000078*/
    IL_0111:  /* 28   | (0A)000016       */ call       class [mscorlib/*23000001*/]System.Type/*01000008*/ [mscorlib/*23000001*/]System.Type/*01000008*/::GetTypeFromHandle(valuetype [mscorlib/*23000001*/]System.RuntimeTypeHandle/*01000034*/) /* 0A000016 */
    IL_0116:  /* A2   |                  */ stelem.ref
    IL_0117:  /* 06   |                  */ ldloc.0
    IL_0118:  /* 80   | (04)00000D       */ stsfld     class [mscorlib/*23000001*/]System.Type/*01000008*/[] System.Linq.Dynamic.ExpressionParser/*0200000A*/::predefinedTypes /* 0400000D */
    IL_011d:  /* 17   |                  */ ldc.i4.1
    IL_011e:  /* 8C   | (01)000033       */ box        [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_0123:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0128:  /* 80   | (04)00000E       */ stsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::trueLiteral /* 0400000E */
    IL_012d:  /* 16   |                  */ ldc.i4.0
    IL_012e:  /* 8C   | (01)000033       */ box        [mscorlib/*23000001*/]System.Boolean/*01000033*/
    IL_0133:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0138:  /* 80   | (04)00000F       */ stsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::falseLiteral /* 0400000F */
    IL_013d:  /* 14   |                  */ ldnull
    IL_013e:  /* 28   | (0A)000024       */ call       class [System.Core/*23000002*/]System.Linq.Expressions.ConstantExpression/*0100003D*/ [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/::Constant(object) /* 0A000024 */
    IL_0143:  /* 80   | (04)000010       */ stsfld     class [System.Core/*23000002*/]System.Linq.Expressions.Expression/*01000009*/ System.Linq.Dynamic.ExpressionParser/*0200000A*/::nullLiteral /* 04000010 */
    IL_0148:  /* 72   | (70)000EC1       */ ldstr      "it" /* 70000EC1 */
    IL_014d:  /* 80   | (04)000011       */ stsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIt /* 04000011 */
    IL_0152:  /* 72   | (70)000EC7       */ ldstr      "iif" /* 70000EC7 */
    IL_0157:  /* 80   | (04)000012       */ stsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordIif /* 04000012 */
    IL_015c:  /* 72   | (70)000ECF       */ ldstr      "new" /* 70000ECF */
    IL_0161:  /* 80   | (04)000013       */ stsfld     string System.Linq.Dynamic.ExpressionParser/*0200000A*/::keywordNew /* 04000013 */
    IL_0166:  /* 2A   |                  */ ret
  } // end of method ExpressionParser::.cctor

} // end of class System.Linq.Dynamic.ExpressionParser

.class /*02000017*/ private abstract auto ansi sealed beforefieldinit System.Linq.Dynamic.Res
       extends [mscorlib/*23000001*/]System.Object/*01000001*/
{
  .field /*04000048*/ public static literal string DuplicateIdentifier = "The identifier '{0}' was defined more than once"
  .field /*04000049*/ public static literal string ExpressionTypeMismatch = "Expression of type '{0}' expected"
  .field /*0400004A*/ public static literal string ExpressionExpected = "Expression expected"
  .field /*0400004B*/ public static literal string InvalidCharacterLiteral = "Character literal must contain exactly one character"
  .field /*0400004C*/ public static literal string InvalidIntegerLiteral = "Invalid integer literal '{0}'"
  .field /*0400004D*/ public static literal string InvalidRealLiteral = "Invalid real literal '{0}'"
  .field /*0400004E*/ public static literal string UnknownIdentifier = "Unknown identifier '{0}'"
  .field /*0400004F*/ public static literal string NoItInScope = "No 'it' is in scope"
  .field /*04000050*/ public static literal string IifRequiresThreeArgs = "The 'iif' function requires three arguments"
  .field /*04000051*/ public static literal string FirstExprMustBeBool = "The first expression must be of type 'Boolean'"
  .field /*04000052*/ public static literal string BothTypesConvertToOther = "Both of the types '{0}' and '{1}' convert to the o"
  + "ther"
  .field /*04000053*/ public static literal string NeitherTypeConvertsToOther = "Neither of the types '{0}' and '{1}' converts to t"
  + "he other"
  .field /*04000054*/ public static literal string MissingAsClause = "Expression is missing an 'as' clause"
  .field /*04000055*/ public static literal string ArgsIncompatibleWithLambda = "Argument list incompatible with lambda expression"
  .field /*04000056*/ public static literal string TypeHasNoNullableForm = "Type '{0}' has no nullable form"
  .field /*04000057*/ public static literal string NoMatchingConstructor = "No matching constructor in type '{0}'"
  .field /*04000058*/ public static literal string AmbiguousConstructorInvocation = "Ambiguous invocation of '{0}' constructor"
  .field /*04000059*/ public static literal string CannotConvertValue = "A value of type '{0}' cannot be converted to type "
  + "'{1}'"
  .field /*0400005A*/ public static literal string NoApplicableMethod = "No applicable method '{0}' exists in type '{1}'"
  .field /*0400005B*/ public static literal string MethodsAreInaccessible = "Methods on type '{0}' are not accessible"
  .field /*0400005C*/ public static literal string MethodIsVoid = "Method '{0}' in type '{1}' does not return a value"
  .field /*0400005D*/ public static literal string AmbiguousMethodInvocation = "Ambiguous invocation of method '{0}' in type '{1}'"
  .field /*0400005E*/ public static literal string UnknownPropertyOrField = "No property or field '{0}' exists in type '{1}'"
  .field /*0400005F*/ public static literal string NoApplicableAggregate = "No applicable aggregate method '{0}' exists"
  .field /*04000060*/ public static literal string CannotIndexMultiDimArray = "Indexing of multi-dimensional arrays is not suppor"
  + "ted"
  .field /*04000061*/ public static literal string InvalidIndex = "Array index must be an integer expression"
  .field /*04000062*/ public static literal string NoApplicableIndexer = "No applicable indexer exists in type '{0}'"
  .field /*04000063*/ public static literal string AmbiguousIndexerInvocation = "Ambiguous invocation of indexer in type '{0}'"
  .field /*04000064*/ public static literal string IncompatibleOperand = "Operator '{0}' incompatible with operand type '{1}'"
  .field /*04000065*/ public static literal string IncompatibleOperands = "Operator '{0}' incompatible with operand types '{1"
  + "}' and '{2}'"
  .field /*04000066*/ public static literal string UnterminatedStringLiteral = "Unterminated string literal"
  .field /*04000067*/ public static literal string InvalidCharacter = "Syntax error '{0}'"
  .field /*04000068*/ public static literal string DigitExpected = "Digit expected"
  .field /*04000069*/ public static literal string SyntaxError = "Syntax error"
  .field /*0400006A*/ public static literal string TokenExpected = "{0} expected"
  .field /*0400006B*/ public static literal string ParseExceptionFormat = "{0} (at index {1})"
  .field /*0400006C*/ public static literal string ColonExpected = "':' expected"
  .field /*0400006D*/ public static literal string OpenParenExpected = "'(' expected"
  .field /*0400006E*/ public static literal string CloseParenOrOperatorExpected = "')' or operator expected"
  .field /*0400006F*/ public static literal string CloseParenOrCommaExpected = "')' or ',' expected"
  .field /*04000070*/ public static literal string DotOrOpenParenExpected = "'.' or '(' expected"
  .field /*04000071*/ public static literal string OpenBracketExpected = "'[' expected"
  .field /*04000072*/ public static literal string CloseBracketOrCommaExpected = "']' or ',' expected"
  .field /*04000073*/ public static literal string IdentifierExpected = "Identifier expected"
} // end of class System.Linq.Dynamic.Res


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file System.Linq.Dynamic.res

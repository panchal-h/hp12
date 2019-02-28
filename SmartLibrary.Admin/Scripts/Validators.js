// this should handle all "" and whitespace situations
String.prototype.isEmptyOrWhiteSpace = function () {
    return (this.length === 0 || !this.trim());
};

//rulesList = pass in list of fields to validate
//messages = pass in list of custom error messages
//highlightErrors = if false, will not highlight fields in red when invalid
//autoFocus = if true, will auto focus on the first item that is not valid in the array
function ValidateForm(rulesList, messages, highlightErrors, autoFocus) {
    //get the asp.net form tag
    var form = $("form");

    var validator = form.validate();
    validator.resetForm();
    validator.reset();

    //reset validators
    form.removeData('validator');

    if (messages == null) {
        messages = {};
    }

    if (highlightErrors == null) {
        jQuery.validator.highlightErrors = true;
    } else {
        jQuery.validator.highlightErrors = highlightErrors;
    }

    if (autoFocus == null) {
        jQuery.validator.autoFocus = true;
    }
    else {
        jQuery.validator.autoFocus = autoFocus;
    }

    form.validate({
        rules: rulesList,
        messages: messages,
    });

    return form.valid();
}

function CancelValidation() {
    var form = $("#form1");
    form.removeData('validator'); //reset validators
    form.validate().cancelSubmit = true;
}

//jquery validate added rules.
$(document).ready(function () {
    $.validator.addMethod("valueNotEquals", function (value, element, arg) {
        return arg != value;
    }, "Please Select a Value.");

    $.validator.addMethod("valueNotEqualsCustomMessage", function (value, element, arg) {
        // allows for a custom error message on valueNotEquals method, passed through arg  
        // else return typical message 
        if (typeof arg === 'object') {
            if ("notEqualValue" in arg) {
                if (arg.notEqualValue == value) {
                    if ("message" in arg) {
                        $.validator.messages.valueNotEqualsCustomMessage = arg.message;
                    }
                    else {
                        $.validator.messages.valueNotEqualsCustomMessage = "Please Select a Value.";
                    }

                    return false;
                }
            }
        }

        return true;
    }, $.validator.messages.valueNotEqualsCustomMessage)



    $.validator.addMethod("integer", function (value, element, arg) {
        if (value.isEmptyOrWhiteSpace()) return true;
        var valid = TestValueWithNoSpaceAgainstRegex(/^(\+|-)?[0-9,]+$/, element.value);

        if (!valid) {
            $.validator.messages.integer = "Please Enter a Valid Numeric Value";
            return false;
        }

        //remove ',' from passed value before trying to compare min and max.
        value = value.replace(/,/g, ''); //javascript string.replace only replaces the first match if a string is passed in (ie, ','). The regex here matches all commas, not just the first.

        if (typeof arg === 'object' && "min" in arg) {
            if (value < arg.min) {
                $.validator.messages.integer = "Value is too low";
                return false;
            }
        }
        if (typeof arg === 'object' && "max" in arg) {
            if (value > arg.max) {
                $.validator.messages.integer = "Value is too high";
                return false;
            }
        }

        return true;

    }, $.validator.messages.integer);

    $.validator.addMethod("customValidator", function (value, element, arg) {

        if (typeof arg === 'object') {
            if ("valid" in arg) {
                if (!arg.valid) {
                    if ("message" in arg) {
                        $.validator.messages.customValidator = arg.message;
                    }
                    return false;
                }
            }
        }
        return true;
    }, $.validator.messages.customValidator);

    $.validator.addMethod("alphanumericspecial", function (value, element, arg) {
        return TestValueWithSpaceAgainstRegex(/(^[A-Za-z0-9:_@.\/#&+-]+(\s*[ A-Za-z0-9:_@.\/#&+-]+)*$)|(^$)/, value);
    }, "Invalid data format in field");

    $.validator.addMethod("propername", function (value, element, arg) {
        return TestValueWithSpaceAgainstRegex(/^([a-zA-Z'.-][ a-zA-Z'.-]*)$/, value);
    }, "Please Enter a Valid Name (Alpha Characters Only)");

    $.validator.addMethod("restrictspecialchar", function (value, element, arg) {
        return TestValueWithSpaceAgainstRegex(/^([^()<>\{\}\[\]\\\/]*)$/, value);
    }, "Your input contains illegal characters.");

    $.validator.addMethod("alphanumeric", function (value, element, arg) {
        return TestValueWithSpaceAgainstRegex(/^([a-zA-Z0-9][a-zA-Z0-9\s]*)$/, value);
    }, "Please Enter a Valid Name (Alpha Numeric Characters Only)");

    $.validator.addMethod("numbersonly", function (value, element, arg) {
        return TestValueWithSpaceAgainstRegex(/^\s*[0-9]*\s*$/, value);
    }, "Invalid data format in field");

    $.validator.addMethod("email", function (value, element, arg) {
        if (value.isEmptyOrWhiteSpace()) return true;
        return TestValueWithNoSpaceAgainstRegex(/^\w+([a-zA-Z0-9!#$%^&*\-+._=])*@(([\w-]+\.)+[\w-]{2,})+$/, value);
    }, "Please Enter a Valid Email");

    $.validator.addMethod("requiredifgreaterthan", function (value, element, args) {
        var obj = $(element);
        var otherObj = $("#" + args.otherproperty);

        if (otherObj.val() == null || otherObj.val() == undefined || otherObj.val() === '') {
            return true;
        }

        return args.othervalue < otherObj.val() ?
            element.type == 'radio' ? value != null && value != undefined && value !== '' : obj.val() != null && obj.val() != undefined && obj.val() !== '' : true;

    }, $.validator.messages.requiredifgreaterthan);

    $.validator.addMethod("requiredifbothvalues", function (value, element, args) {
        var obj = $(element);
        var value1 = GetElementValue(args.property1);
        var value2 = GetElementValue(args.property2);

        if (value1 == null || value1 == undefined || value1 === '') {
            return true;
        }
        if (value2 == null || value2 == undefined || value2 === '') {
            return true;
        }

        return ($.inArray(value1, JSON.parse(args.values1)) >= 0) && ($.inArray(value2, JSON.parse(args.values2)) >= 0) ?
            element.type == 'radio' ? value != null && value != undefined && value !== '' : obj.val() != null && obj.val() != undefined && obj.val() !== '' : true;


    }, $.validator.messages.requiredifbothvalues);

    $.validator.addMethod("requiredifeithervalue", function (value, element, args) {
        var obj = $(element);
        var value1 = GetElementValue(args.property1);
        var value2 = GetElementValue(args.property2);

        if (value1 == null || value1 == undefined || value1 === '') {
            return true;
        }
        if (value2 == null || value2 == undefined || value2 === '') {
            return true;
        }

        return ($.inArray(value1, JSON.parse(args.values1)) >= 0) || ($.inArray(value2, JSON.parse(args.values2)) >= 0) ?
            element.type == 'radio' ? value != null && value != undefined && value !== '' : obj.val() != null && obj.val() != undefined && obj.val() !== '' : true;

    }, $.validator.messages.requiredifeithervalue);

    $.validator.addMethod("requiredifcustomcondition", function (value, element, args) {

        var obj = $(element);
        var customCondition = JSON.parse(args.customcondition);

        if (customCondition == null || customCondition == undefined || customCondition === '') {
            return false;
        }

        var GetData = GetCustomConditionDetails(customCondition);

        var finalValue = element.type == 'radio' ? value : obj.val();

        if (eval(GetData.strFinalCondition) && finalValue != null && finalValue != undefined && finalValue !== '') {
            return true;
        }

        return false;

    }, $.validator.messages.requiredifcustomcondition);

    $.validator.addMethod("HttpPostedFileExtensionAndSizeAttribute", function (value, element, args) {
        if (element.value.isEmptyOrWhiteSpace()) return true;

        if (element.files[0].size > uploadFileLimitBytes) {
            $.validator.messages.httppostedfileextension = FileSizeError;
            return false;
        }

        var validTypes = args.validtypes.split(',');
        var pathSegments = element.value.split('.');
        var fileType = pathSegments[pathSegments.length - 1].toString().toLowerCase();
        for (i = 0; i < validTypes.length; i++) {
            var validType = validTypes[i];
            if (validType == fileType) {
                return true;
            }
        }
        $.validator.messages.httppostedfileextension = FileTypeError;
        return false;

    }, $.validator.messages.HttpPostedFileExtensionAndSizeAttribute);
});

function GetCustomConditionDetails(customCondition) {
    var matchesProperty = customCondition.match(/\[(.*?)\]/g);
    var matchesValue = customCondition.match(/\'(.*?)\'/g);

    var strFinalCondition = customCondition;
    var listProperty = '';

    $.each(matchesProperty, function (index, value) {
        if (listProperty == '') {
            listProperty = value.replace('[', '#').replace(']', '');
        }
        else {
            listProperty = listProperty + ', ' + value.replace('[', '#').replace(']', '');
        }
        strFinalCondition = strFinalCondition.replace(value, '$("#' +
                                    value.replace('[', '').replace(']', '') + '").val().toLowerCase()');
    });

    $.each(matchesValue, function (index, value) {
        strFinalCondition = strFinalCondition.replace(value, value + '.toLowerCase()');
    });

    return {
        strFinalCondition: strFinalCondition,
        listProperty: listProperty
    };
}

function TestValueWithNoSpaceAgainstRegex(regExp, value) {
    if (regExp.test(value.replace(/^\s+|\s+$/g, ''))) {
        return true;
    } else {
        return false;
    }
}

function TestValueWithSpaceAgainstRegex(regExp, value) {
    if (value == "") {
        return true;
    }
    else if (regExp.test(value)) {
        return true;
    } else {
        return false;
    }
}

function ProcessVisibleIfGreaterThanAttributes() {
    $("input, select").each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleifgreaterthan') {
                var classToHide = $(this).attr('data-val-visibleifgreaterthan-classtohide');
                var otherProperty = $(this).attr('data-val-visibleifgreaterthan-otherproperty');
                var otherValue = parseInt($(this).attr('data-val-visibleifgreaterthan-othervalue'));

                ApplyShowHideLogic(otherProperty, otherValue, classToHide, function compare(propertyValue, valueToCompare) {
                    return propertyValue > valueToCompare;
                });
            }
        }
    });
}

function ProcessVisibleIfAnyValueAttributes() {
    $("input").each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleifanyvalue') {
                var classToHide = $(this).attr('data-val-visibleifanyvalue-classtohide');
                var otherProperty = $(this).attr('data-val-visibleifanyvalue-otherproperty');
                var otherValues = $(this).attr('data-val-visibleifanyvalue-othervalues');

                ApplyShowHideLogic(otherProperty, otherValues, classToHide, function compare(propertyValue, valueToCompare) {
                    return $.inArray(propertyValue, JSON.parse(valueToCompare)) >= 0;
                });
            }
        }
    });
}

function ProcessVisibleIfValueAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleifvalue') {
                var classToHide = $(this).attr('data-val-visibleifvalue-classtohide');
                var otherProperty = $(this).attr('data-val-visibleifvalue-otherproperty');
                var otherValue = $(this).attr('data-val-visibleifvalue-othervalue');
                ApplyShowHideLogic(otherProperty, otherValue, classToHide, function compare(propertyValue, valueToCompare) {
                    return propertyValue === valueToCompare;
                });
            }
        }
    });
}

function ProcessVisibleIfAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleif') {
                var classToHide = $(this).attr('data-val-visibleif-classtohide');
                var otherProperty = $(this).attr('data-val-visibleif-otherproperty');

                ApplyShowHideLogic(otherProperty, null, classToHide, function compare(propertyValue, valueToCompare) {
                    return propertyValue == null || propertyValue == undefined || propertyValue === '';
                });
            }
        }
    });
}

function ProcessVisibleIfAllPropertyValuesAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleifallpropertyvalues') {
                var classToHide = $(this).attr('data-val-visibleifallpropertyvalues-classtohide');
                var property1 = $(this).attr('data-val-visibleifallpropertyvalues-property1');
                var value1 = $(this).attr('data-val-visibleifallpropertyvalues-value1');
                var property2 = $(this).attr('data-val-visibleifallpropertyvalues-property2');
                var value2 = $(this).attr('data-val-visibleifallpropertyvalues-value2');

                ApplyShowHideLogicForTwoProperty(property1, value1, property2, value2, classToHide,
                    function compare(property1Value, value1ToCompare, property2Value, value2ToCompare) {
                        return property1Value === value1ToCompare && property2Value === value2ToCompare;
                    });
            }
        }
    });
}

function ProcessVisibleIfAnyPropertyValuesAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {

            if (data === 'valVisibleifanypropertyvalues') {

                var classToHide = $(this).attr('data-val-visibleifanypropertyvalues-classtohide');
                var property1 = $(this).attr('data-val-visibleifanypropertyvalues-property1');
                var value1 = $(this).attr('data-val-visibleifanypropertyvalues-value1');
                var property2 = $(this).attr('data-val-visibleifanypropertyvalues-property2');
                var value2 = $(this).attr('data-val-visibleifanypropertyvalues-value2');

                ApplyShowHideLogicForTwoProperty(property1, value1, property2, value2, classToHide,
                    function compare(property1Value, value1ToCompare, property2Value, value2ToCompare) {
                        return property1Value === value1ToCompare || property2Value === value2ToCompare;
                    });
            }
        }
    });
}

function ProcessVisibleIfCustomConditionAttributes() {

    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valVisibleifcustomconditionvalue') {
                var classToHide = $(this).attr('data-val-visibleifcustomconditionvalue-classtohide');
                var customCondition = $(this).attr('data-val-visibleifcustomconditionvalue-customcondition');

                var GetData = GetCustomConditionDetails(customCondition);

                ApplyShowHideLogicForCustomCondition(classToHide, GetData.listProperty, GetData.strFinalCondition);
            }
        }
    });
}

function ApplyShowHideLogicForCustomCondition(className, listProperty, strFinalCondition) {

    if (eval(strFinalCondition)) {
        $("." + className).show();
        $(".not-" + className).hide();
    } else {
        $("." + className).hide();
        $(".not-" + className).show();
    }

    $(listProperty).change(function () {
        if (eval(strFinalCondition)) {
            $("." + className).show();
            $(".not-" + className).hide();
        } else {
            $("." + className).hide();
            $(".not-" + className).show();
        }
    });
}

function ProcessHiddenIfGreaterThanAttributes() {
    $("input, select").each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenifgreaterthan') {
                var classToHide = $(this).attr('data-val-hiddenifgreaterthan-classtohide');
                var otherProperty = $(this).attr('data-val-hiddenifgreaterthan-otherproperty');
                var otherValue = parseInt($(this).attr('data-val-hiddenifgreaterthan-othervalue'));

                ApplyShowHideLogic(otherProperty, otherValue, classToHide, function compare(propertyValue, valueToCompare) {
                    return propertyValue <= valueToCompare;
                });
            }
        }
    });
}

function ProcessHiddenIfAnyValueAttributes() {
    $("input").each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenifanyvalue') {
                var classToHide = $(this).attr('data-val-hiddenifanyvalue-classtohide');
                var otherProperty = $(this).attr('data-val-hiddenifanyvalue-otherproperty');
                var otherValues = $(this).attr('data-val-hiddenifanyvalue-othervalues');

                ApplyShowHideLogic(otherProperty, otherValues, classToHide, function compare(propertyValue, valueToCompare) {
                    return $.inArray(propertyValue, JSON.parse(valueToCompare)) < 0;
                });
            }
        }
    });
}

function ProcessHiddenIfValueAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenifvalue') {
                var classToHide = $(this).attr('data-val-hiddenifvalue-classtohide');
                var otherProperty = $(this).attr('data-val-hiddenifvalue-otherproperty');
                var otherValue = $(this).attr('data-val-hiddenifvalue-othervalue');

                ApplyShowHideLogic(otherProperty, otherValue, classToHide, function compare(propertyValue, valueToCompare) {
                    return propertyValue != valueToCompare;
                });
            }
        }
    });
}

function ProcessHiddenIfAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenif') {
                var classToHide = $(this).attr('data-val-hiddenif-classtohide');
                var otherProperty = $(this).attr('data-val-hiddenif-otherproperty');

                ApplyShowHideLogic(otherProperty, null, classToHide, function compare(propertyValue, valueToCompare) {
                    return !(propertyValue == null || propertyValue == undefined || propertyValue === '');
                });
            }
        }
    });
}

function ProcessHiddenIfAllPropertyValuesAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenifallpropertyvalues') {
                var classToHide = $(this).attr('data-val-hiddenifallpropertyvalues-classtohide');
                var property1 = $(this).attr('data-val-hiddenifallpropertyvalues-property1');
                var value1 = $(this).attr('data-val-hiddenifallpropertyvalues-value1');
                var property2 = $(this).attr('data-val-hiddenifallpropertyvalues-property2');
                var value2 = $(this).attr('data-val-hiddenifallpropertyvalues-value2');

                ApplyShowHideLogicForTwoProperty(property1, value1, property2, value2, classToHide,
                    function compare(property1Value, value1ToCompare, property2Value, value2ToCompare) {
                        return !(property1Value === value1ToCompare && property2Value === value2ToCompare);
                    });
            }
        }
    });
}

function ProcessHiddenIfAnyPropertyValuesAttributes() {
    $('input, select').each(function () {
        for (data in $(this).data()) {
            if (data === 'valHiddenifanypropertyvalues') {
                var classToHide = $(this).attr('data-val-hiddenifanypropertyvalues-classtohide');
                var property1 = $(this).attr('data-val-hiddenifanypropertyvalues-property1');
                var value1 = $(this).attr('data-val-hiddenifanypropertyvalues-value1');
                var property2 = $(this).attr('data-val-hiddenifanypropertyvalues-property2');
                var value2 = $(this).attr('data-val-hiddenifanypropertyvalues-value2');

                ApplyShowHideLogicForTwoProperty(property1, value1, property2, value2, classToHide,
                    function compare(property1Value, value1ToCompare, property2Value, value2ToCompare) {
                        return !(property1Value === value1ToCompare || property2Value === value2ToCompare);
                    });
            }
        }
    });
}

function ApplyShowHideLogicForTwoProperty(property1, value1, property2, value2, className, compareFunction) {

    var otherProperty1 = property1;
    var otherValue1 = value1;
    var otherProperty2 = property2;
    var otherValue2 = value2;
    var classToHide = className;

    // set based on current value
    var property1Value = GetElementValue(otherProperty1);
    var property2Value = GetElementValue(otherProperty2);
    if (compareFunction(property1Value, otherValue1, property2Value, otherValue2)) {
        $("." + classToHide).show();
        $(".not-" + classToHide).hide();
    } else {
        $("." + classToHide).hide();
        $(".not-" + classToHide).show();
    }

    // Setup change event
    $(GetElement(otherProperty1) + ", " + GetElement(otherProperty2)).change(function () {
        var value1 = otherValue1;
        var value2 = otherValue2;
        var property1 = otherProperty1;
        var property2 = otherProperty2;
        var element = classToHide;
        var property1Value = GetElementValue(property1);
        var property2Value = GetElementValue(property2);
        if (compareFunction(property1Value, value1, property2Value, value2)) {
            $("." + element).show();
            $(".not-" + element).hide();
        } else {
            $("." + element).hide();
            $(".not-" + element).show();
        }
    });
}

function GetElementValue(element) {
    if ($("#" + element).is(':radio')) {
        return $("input[name=" + element + "]:checked").val();
    } else {
        return $("#" + element).val();
    }
}

function GetElement(element) {
    if ($("#" + element).is(':radio')) {
        return "input[name=" + element + "]:radio";
    } else {
        return "#" + element;
    }
}

function ApplyShowHideLogic(property, value, className, compareFunction) {

    var otherProperty = property;
    var otherValue = value;
    var classToHide = className;

    // set based on current value
    var propertyValue = GetElementValue(otherProperty);
    if (compareFunction(propertyValue, otherValue)) {
        $("." + classToHide).show();
        $(".not-" + classToHide).hide();
    } else {
        $("." + classToHide).hide();
        $(".not-" + classToHide).show();
    }

    // Setup change event
    $(GetElement(otherProperty)).change(function () {
        var value = otherValue;
        var property = otherProperty;
        var element = classToHide;
        var propertyValue = GetElementValue(property);

        //alert("value = " + value + "; property = " + property + "; element = " + element + "; propertyValue = " + propertyValue)

        if (compareFunction(propertyValue, value)) {
            $("." + element).show();
            $(".not-" + element).hide();
        } else {
            $("." + element).hide();
            $(".not-" + element).show();
        }
    });
}

$(function () {

    jQuery.validator.unobtrusive.adapters.add('email', function (options) {
        options.rules['email'] = {};
        options.messages['email'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('alphanumericspecial', function (options) {
        options.rules['alphanumericspecial'] = {};
        options.messages['alphanumericspecial'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('propername', function (options) {
        options.rules['propername'] = {};
        options.messages['propername'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('restrictspecialchar', function (options) {
        options.rules['restrictspecialchar']= { };
        options.messages['restrictspecialchar']= options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('alphanumeric', function (options) {
        options.rules['alphanumeric'] = {};
        options.messages['alphanumeric'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('integer', function (options) {
        options.rules['integer'] = {};
        options.messages['integer'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('numbersonly', function (options) {
        options.rules['numbersonly'] = {};
        options.messages['numbersonly'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('requiredifgreaterthan', ["otherproperty", "othervalue"], function (options) {
        options.rules['requiredifgreaterthan'] = { otherproperty: options.params.otherproperty, othervalue: options.params.othervalue };
        options.messages['requiredifgreaterthan'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('requiredifbothvalues', ["property1", "values1", "property2", "values2"], function (options) {

        options.rules['requiredifbothvalues'] = { property1: options.params.property1, values1: options.params.values1, property2: options.params.property2, values2: options.params.values2 };
        options.messages['requiredifbothvalues'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('requiredifeithervalue', ["property1", "values1", "property2", "values2"], function (options) {
        options.rules['requiredifeithervalue'] = { property1: options.params.property1, values1: options.params.values1, property2: options.params.property2, values2: options.params.values2 };
        options.messages['requiredifeithervalue'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('requiredifcustomcondition', ["customcondition"], function (options) {
        options.rules['requiredifcustomcondition'] = { customcondition: options.params.customcondition };
        options.messages['requiredifcustomcondition'] = options.message;
    });

    jQuery.validator.unobtrusive.adapters.add('HttpPostedFileExtensionAndSizeAttribute', ["validtypes"], function (options) {
        options.rules['HttpPostedFileExtensionAndSizeAttribute'] = { validtypes: options.params.validtypes };
        options.messages['HttpPostedFileExtensionAndSizeAttribute'] = options.message;
    });

    ProcessVisibleIfAttributes();
    ProcessVisibleIfValueAttributes();
    ProcessVisibleIfAnyValueAttributes();
    ProcessVisibleIfGreaterThanAttributes();
    ProcessVisibleIfAllPropertyValuesAttributes();
    ProcessVisibleIfAnyPropertyValuesAttributes();
    ProcessVisibleIfCustomConditionAttributes();
    ProcessHiddenIfAttributes();
    ProcessHiddenIfValueAttributes();
    ProcessHiddenIfAnyValueAttributes();
    ProcessHiddenIfGreaterThanAttributes();
    ProcessHiddenIfAllPropertyValuesAttributes();
    ProcessHiddenIfAnyPropertyValuesAttributes();

    jQuery.validator.setDefaults({

        ignore: ":hidden:not(.imgDropDown):not(.commonDropDown)",
        invalidHandler: function (event, validator) {
            if (jQuery.validator.autoFocus == null || jQuery.validator.autoFocus == true) {
                var errors = validator.numberOfInvalids();
                if (errors && validator.errorList[0] != undefined) {
                    validator.errorList[0].element.focus();
                }
            }
        },


        showErrors: function (errorMap, errorList) {
            if (jQuery.validator.highlightErrors == null || jQuery.validator.highlightErrors == true) {
                // clean up valid elements
                $.each(this.validElements(), function (index, element) {

                    //get closest surrounding control-group
                    var $element = $(element).closest('.form-control');

                    //if form-group not found, remove class to object itself
                    if ($element == null || $element.length == 0) {
                        $element = $(element);
                    }

                    // IF dropdown-toggle control found then remove class to it
                    if ($($element.siblings()[0]).hasClass('dropdown-toggle')) {
                        $element =$($element.siblings()[0]);
                    }

                    //remove error classes
                    $element.addClass('valid').removeClass('input-validation-error').removeClass('has-error').addClass('success');

                    //clear tooltips
                    $element.data("title", "").removeClass("error").popover("destroy");
                });

                // process invalid elements
                $.each(errorList, function (index, error) {
                    //get closest surrounding control-group
                    var $element = $(error.element).closest('.form-control');

                    //if form-group not found, add class to object itself
                    if ($element == null || $element.length == 0) {
                        $element = $(error.element);
                    }

                    // IF dropdown-toggle control found then remove class to it
                    if ($($element.siblings()[0]).hasClass('dropdown-toggle')) {
                        $element = $($element.siblings()[0]);
                    }

                    //add error class
                    $element.removeClass('success').addClass('input-validation-error').addClass('has-error');

                    //add tooltips
                    $element.popover("destroy").popover({
                        container: 'body',
                        content: error.message,
                        toggle: "popover",
                        placement: "top",
                        trigger: "hover"
                    });
                });

            }
            jQuery.validator.highlightErrors = null;
        }
    });
}(jQuery));

$.validator.methods.range = function (value, element, param) {
    //remove ',' from passed value before trying to compare min and max.
    value = value.replace(/,/g, ''); //javascript string.replace only replaces the first match if a string is passed in (ie, ','). The regex here matches all commas, not just the first.

    return this.optional(element) || (value >= param[0] && value <= param[1]);
}
jQuery.validator.methods["date"] = function (value, element) {
    return this.optional(element) || !/Invalid|NaN/.test(moment(value, "YYYY/MM/DD").toDate().toString());
}

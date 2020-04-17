
$(document).ready(function () {

    load_json_data('country');

    function load_json_data(id) {
        $('#country').html('<option disabled  selected value="">---Select country---</option>');
        var jqxhr = $.getJSON("../Content/JsonFile/countries.json", function (data) {

            $.each(data, function (key, value) {
                $('#country').html($('#country').html() + '<option value="' + value.id + '">' + value.name + '</option>');
            });
        });
    }
    $(document).on('change', '#country', function () {
        $('#state').html('<option disabled selected value="">---Select your State---</option>');
        var country_id = $(this).val();
        if (country_id != '') {
            var jqxhr1 = $.getJSON("../Content/JsonFile/states.json", function (data) {

                $.each(data, function (key, value) {

                    if (value.country_id == country_id) {
                        $('#state').html($('#state').html() + '<option value="' + value.state_code + '">' + value.name + '</option>');
                    }
                });
            });
        }
        else {
            $('#state').html('<option value="">Select state</option>');
        }
    });
    $(document).on('change', '#state', function () {
        $('#city').html('<option disabled selected value="">---Select your City---</option>');
        var state_code = $(this).val();
        $('#city').html($('#city').html() + '<option ></option>');
        if (state_code != '') {
            var jqxhr1 = $.getJSON("../Content/JsonFile/cities.json", function (data) {
                $.each(data, function (key, value) {
                    if (value.state_code == state_code) {
                        $('#city').html($('#city').html() + '<option value="' + value.id + '">' + value.name + '</option>');
                    }

                });
            });
        }
        else {
            $('#city').html('<option value="">Select city</option>');
        }
    });
});
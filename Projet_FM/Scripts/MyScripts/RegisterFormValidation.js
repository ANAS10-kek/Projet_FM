$(document).ready(function () {
    $('#formRegister').validate(
        {

            errorClass: 'help-block animation-slideDown text-danger',
            errorElement: 'span',
            errorPlacement: function (error, e) {
                e.parents('.form-control').append(error);
            },
            highlight: function (e) {

                $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
                $(e).closest('.help-block').remove();
            },
            success: function (e) {
                e.closest('.form-group').removeClass('has-success has-error');
                e.closest('.help-block').remove();
            },
            rules: {
                'firstName': {
                    required: true
                },

                'lastName': {
                    required: true
                },
                'UserName': {
                    required: true
                },
                'Email': {
                    required: true,
                    email:true
                },
                'Password': {
                    required: true,
                    password:true,
                    minlength: 6
                },
                'ConfirmPassword': {
                    required: true,
                    equalTo: "#Password"
                },
                'PhoneNumber': {
                    required: true,
                    matches: "[0-9]+"
                },
                'Address': {
                    required: true
                },
                'Country': {
                    required: true
                },
                'State': {
                    required: true
                },
                'City': {
                    required: true
                },
            },
            messages: {
                'firstName': {
                    required: "first Name is required"
                },

                'lastName': {
                    required: " last Name is required"
                },
                'UserName': {
                    required: "UserName is required"
                },
                'Email': {
                    required: "Email is required",
                    email: true
                },
                'Password': {
                    required: "Password is required",
                    minlength: "min lenght is 6 caractere"
                },
                'ConfirmPassword': {
                    required: "Confirm Password is required",
                    equalTo: "Password and Confirmation Password not much"
                },
                'PhoneNumber': {
                    required: "Phone Number is required",
                    matches: "[0-9]+"
                },
                'Address': {
                    required: "Address is required"
                },
                'Country': {
                    required: "Country is required"
                },
                'State': {
                    required: "State is required"
                },
                'City': {
                    required: "City is required"
                }
            }
        });
});
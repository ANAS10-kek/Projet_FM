$(document).ready(function () {
    $('#ContactUsForm').validate(
        {
            errorClass: 'help-block animation-slideDown', // You can change the animation class for a different entrance animation - check animations page  
            errorElement: 'div',
            errorPlacement: function (error, e) {
                e.parents('.form-group > div').append(error);
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
                'Email': {
                    required: true,
                    email: true
                },

                'Name': {
                    required: true
                },
                'Subject': {
                    required: true
                },
                'Message': {
                    required: true
                },
            },
            messages: {
                'Email':
                {
                    required: 'Please enter valid email address'
                },
                'Message': {
                    required: 'Message is required'
                },
                'Subject': {
                    required: 'Subject is required'
                },
                'Name': {
                    required: 'Name is required'
                }

            }
        });
});
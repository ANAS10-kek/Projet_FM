$(document).ready(function () {
    $('#ContactUsForm').validate(
        {
            
            errorClass: 'help-block animation-slideDown text-danger',
            errorElement: 'span',
            errorPlacement: function (error, e) {
                e.parents('.form-group > div').append(error);
            },
            highlight: function (e) {

                $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
                $(e).closest('.help-block').remove();
            },
            success: function (e) {
                alert("fsf");
                e.closest('.form-group').removeClass('has-success has-error');
                e.closest('.help-block').remove();
            },
            rules: {
                'Subject_M': {
                    required: true,
                    email: true
                },

                'Name_M': {
                    required: true
                },
                'Subject_M': {
                    required: true
                },
                'Subject_M': {
                    required: true
                },
            },
            messages: {
                'Email_M':
                {
                    required: 'Please enter valid email address'
                },
                'Message_M': {
                    required: 'Message is required'
                },
                'Subject_M': {
                    required: 'Subject is required'
                },
                'Name_M': {
                    required: 'Name is required'
                }
            }
        });
});
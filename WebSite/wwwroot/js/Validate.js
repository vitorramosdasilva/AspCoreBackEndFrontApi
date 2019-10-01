$(document).ready(function () {
    $("#myform").validate({
    error: function (label) {
        $(this).addClass("error");
    }
  });
});

/*
$.validate.addMethod("dateFormat",
    function (value, element) {
        return value.match(/^dd?-dd?-dd$/);
    },"Por favor insira a data em formato dd-mm-yyyy.");
*/


$(document).ready(function () {
    $("#MyForm").validate({
        rules: {
            NomeCompleto: {
                required: true,
                minlength: 10
            },
            Senha: {
                required: true,
                minLength: 5,
                maxLength: 8,
                password:true
            },
            Email: {
                required: true,
                email: true
            },
            DataNascimento: {
                required: true,
                date: true             

            },
        },
        
        messages: {

            NomeCompleto: {
                required: "Por favor insira o nome completo.",
                minLength: "Nome Completo Minimo de 10 caracteres"
            },
            Senha: {
                required: "Por favor insira a senha",
                minLength: "Minimo de 5 caracteres na senha",
                maxLength: "Máximo de 8 caracteres na senha"
            },
            Email: {
                required: "Insira email valido."
            },
            DataNascimento: "Insira a Data de Nascimento em Formato dd/mm/aaaa",
            date: true
        }
    });
});


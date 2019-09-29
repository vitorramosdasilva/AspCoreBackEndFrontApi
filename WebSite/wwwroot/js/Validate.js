$(document).ready(function () {
    $("#MyForm").validate({
        rules: {
            NomeCompleto: {
                required: true,
                minlength: 10
            },
            Senha: {
                required: true,
                minLength: 5
            },
            Email: {
                required: true,
                email: true
            },
            DataNascimento: {
                required: true

            },
        },
        messages: {

            NomeCompleto: {
                required: "Por favor insira o nome completo.",
                minLength: "Nome Completo Minimo de 10 caracteres"
            },
            Senha: {
                required: "Por favor insira a senha",
                minLength: "Senha como no minimo de 5 caracteres"
            },
            Email: {
                required: "Insira email valido."
            },
            DataNascimento: "Insira a Data de Nascimento",
            date: true
        }
    });
}
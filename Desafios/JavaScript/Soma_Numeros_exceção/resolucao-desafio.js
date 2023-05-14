//Desafios JavaScript na DIO têm funções "gets" e "print" acessíveis globalmente:
//- "gets" : lê UMA linha com dado(s) de entrada (inputs) do usuário;
//- "print": imprime um texto de saída (output), pulando linha.

const limite = parseInt(gets());

function somaNumeros(limite) {
    let soma = 0;
    for (let i = 1; i <= limite; i++) {
        if (i % 3 != 0) {
            soma += i;
        }
    }
    return soma;
}

//TODO: Imprima a saída no padrão definido neste desafio.
const soma = somaNumeros(limite);
print(`Soma dos números de 1 a ${limite}, exceto os divisíveis por 3: ${soma}`);

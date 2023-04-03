
/* 
    1) Faça um algorítimo que dado as 3 notas tiradas por um aluno em um semestre da faculdade calcule e imprima a sua média e a sua classificação conforme a tabela abaixo.

    Média = (nota 1 + nota 2 + nota 3) / 3;

    Classificação:
    - Média menor que 5, reprovação;
    - Média entre 5 e 7, recuperação;
    - Média acima de 7, passou de semestre;
*/

const notasAluno = [5, 8.7, 9];

const media = (notasAluno[0] + notasAluno[1] + notasAluno[2]) / 3

if (media < 5) {
    console.log(`Reprovado`)
} else if (media >= 5 && media <= 7) {
    console.log(`Recuperação`)
} else {
    console.log(`Passou de semestre`)
}

/*
    2) O IMC – Indice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. 

    Formula do IMC:
    IMC = peso / (altura * altura)

    Elabore um algoritmo que dado o peso e a altura de um adulto mostre sua condição de acordo com a tabela abaixo.

    IMC em adultos Condição:
    - Abaixo de 18.5 Abaixo do peso;
    - Entre 18.5 e 25 Peso normal;
    - Entre 25 e 30 Acima do peso;
    - Entre 30 e 40 Obeso;
    - Acima de 40 Obsesidade Grave;
*/

const altura = 1.80;
const peso = 80;

const imc = peso / Math.pow(altura, 2)

if (imc < 18.5) {
    console.log(`Abaixo do peso`)
} else if (imc >= 18.5 && imc < 25) {
    console.log(`Peso normal`)
} else if (imc >= 25 && imc < 30) {
    console.log(`Acima do peso`)
} else if (imc > +30 && imc < 40) {
    console.log(`Obeso`)
} else {
    console.log(`Obesidade Grave`)
}

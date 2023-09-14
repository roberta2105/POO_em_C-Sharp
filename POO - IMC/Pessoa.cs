using System;
using System.Xml.Serialization;

class Pessoa
    {
        public double peso;
        public double altura;

        public double Calculo()
        {
            return peso / (altura * altura);
        }

        public string Resultado(double imc)
        {
            string retorno;

            if(imc < 18.5){
                retorno = "Abaixo do peso";
            }
            else if(imc < 25){
                retorno = "Peso normal";
            }
            else if(imc < 30){
                retorno = "Acima do peso";
            }
            else if(imc < 35){
                retorno = "Obesidade I";
            }
            else if(imc < 40){
                retorno = "Obesidade II";
            }
            else{
                retorno = "Obesidade III";
            }
            return retorno;
        }
        public void Mensagem()
        {

             double obterCalculo = Calculo();
             string obterResultado = Resultado(obterCalculo);

             Console.WriteLine($"O seu IMC é: {obterCalculo}");
             Console.WriteLine($"A sua situação é: {obterResultado}");
        }

       
    }
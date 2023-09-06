using System;

class Pessoa {

    //Atributos
    public double peso;
    public double altura;
    
    //Calculo
    public double imc()
    {
        return peso / (altura * altura);
    }
    
    //Situacao
    public string situacao(double imc){
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
        else(imc >= 40){
            retorno = "Obesidade III";
        }
        
        //Mensagem
        public void mensagem(){
            
            //Obter calculo
            double obterIMC = imc();
            
            //Obter a situação
            string obterSituacao = situacao(obterIMC);
            
            //Mensagem
            Console.WriteLine("O paciente está: " + obterIMC+ " com o IMC em: " + obeterSituacao);
        }
    }
}
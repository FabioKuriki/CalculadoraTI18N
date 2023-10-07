using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
    class Calculadora
    {
        //Variáveis Globais
        private double num1;
        private double num2;
        //Método construtor -> Instância as variáveis na memória do computador
        public Calculadora()
        {
            ConsultarNum1 = 0;
            ConsultarNum2 = 0;
        }//Fim do método construtor

        //Métodos Modificadores = GET e SET
        public double ConsultarNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//Fim do método ConsultarNum1

        public double ConsultarNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do método ConsultarNum2

        //Métodos
        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;
        }//Fim do Somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum2;
        }//Fim do Subtrair

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }//Fim do Multiplicar

        public double Dividir()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//Fim do Dividir


    }//Fim da classe
}//Fim do Projeto

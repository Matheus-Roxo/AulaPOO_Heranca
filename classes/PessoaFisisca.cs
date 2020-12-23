namespace AulaPOO_Heranca.classes
{
    public class PessoaFisisca : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidarCPF(string documento){
            
            if(documento != ""){
                return true;
            }
            // DarBoasindas("Juan");
            // nome = "Exemplo";
            return true;
        }
    }
}
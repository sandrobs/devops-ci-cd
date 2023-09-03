namespace BlazorApp;

    public class Validacoes
    {
        
        public static bool ValidaCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", ""); // Remove pontos e traço do CPF

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }
            int resto = (soma * 10) % 11;
            if (resto == 10)
            {
                resto = 0;
            }
            if (resto != int.Parse(cpf[9].ToString()))
            {
                return false;
            }

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }
            resto = (soma * 10) % 11;
            if (resto == 10)
            {
                resto = 0;
            }
            if (resto != int.Parse(cpf[10].ToString()))
            {
                return false;
            }

            return true;
        }

    }

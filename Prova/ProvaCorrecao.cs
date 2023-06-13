using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

class ProvaCorrecao
{
    private char[] gabaritocorreto = {'a', 'b', 'd', 'e', 'c', 'a', 'a', 'd', 'e', 'b'};
    private char[] resposta = new char[10];
    public void RespostaAluno(char gabarito)
    {
        for (int i = 0; i < resposta.Length; i++)
        {

            if (resposta[i] == 0)
            {
                resposta[i] = gabarito;
            }

        }
    }

    public int Correcao()
    {
        int result = 0;
        for (int i = 0; i < gabaritocorreto.Length; i++)
        {
            if (resposta[i] == gabaritocorreto[i])
            {
                result+= 1;
            }
        }
        

        return result;
    }
}
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

class ProvaCorrecao
{
    private char[] gabaritocorreto = {'a', 'b', 'd', 'e', 'c', 'a', 'a', 'd', 'e', 'b'};
    private char[] resposta = new char[10];
    public void RespostaAluno(char a, char b, char c, char d, char e, char f, char g, char h, char i, char j)
    {
        
        resposta[0] = a;
        resposta[1] = b;
        resposta[2] = c;
        resposta[3] = d;
        resposta[4] = e;
        resposta[5] = f;
        resposta[6] = g;
        resposta[7] = h;
        resposta[8] = i;
        resposta[9] = j;



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
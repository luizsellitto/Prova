using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

class ProvaCorrecao
{
    private char[] gabaritocorreto = {'a', 'b', 'd', 'e', 'c', 'a', 'a', 'd', 'e', 'b'};
    private char[] resposta = new char[10];
    public void RespostaAluno(char a, char b, char c, char d, char e, char f, char g, char h, char i, char j)
    {
        
        resposta[0] = Convert.ToChar(a.ToString().ToLower());
        resposta[1] = Convert.ToChar(b.ToString().ToLower());
        resposta[2] = Convert.ToChar(c.ToString().ToLower());
        resposta[3] = Convert.ToChar(d.ToString().ToLower());
        resposta[4] = Convert.ToChar(e.ToString().ToLower());
        resposta[5] = Convert.ToChar(f.ToString().ToLower());
        resposta[6] = Convert.ToChar(g.ToString().ToLower());
        resposta[7] = Convert.ToChar(h.ToString().ToLower());
        resposta[8] = Convert.ToChar(i.ToString().ToLower());
        resposta[9] = Convert.ToChar(j.ToString().ToLower());





    }

    public int Correcao()
    {int result = 0;
        try
        {
            
            for (int i = 0; i < gabaritocorreto.Length; i++)
            {
                if (resposta[i] == gabaritocorreto[i])
                {
                    result += 1;
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Está dando erro!");
        }
        return result;
        

        
    }
}
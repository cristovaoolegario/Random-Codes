public class HelloWorld 
{
	public static void main(String[] args) 
	{
		TelefoneEletronico t = new TelefoneEletronico();
        t.Ring();
	}
}
class TelefoneEletronico extends Telefone
{
    public TelefoneEletronico() 
    {
        set("digital");
    }
    public void set(String set)
    {
    	tipo = set;
    }            
}

class Telefone
{
    protected String tipo = " ";

    public void Ring()
    {
    	System.out.println("Tocando o "+ tipo);
    }
   
    Telefone()
    {
    	tipo = " ";
    }
}

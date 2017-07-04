//Usando eventos para simularo um departamento de incendio

using System;

//Classe FireAlarmEventArgs deriva de EventArgs e contem informacoes de eventos
class FireAlarmEventArgs : EventArgs
{
   private string location;

   public FireAlarmEventArgs( string location )
   {
		this.location = location;
   }

   public string Location{get{return location;}}

} // finaliza classe FireAlarmEventArgs

//Classe SmokeDetector define o evento delegado, objeto e chama o delegate quando o evento e levantado
class SmokeDetector
{
   string location;

   //Define um evento delegado
   public delegate void FireAlarmEventHandler( object sender, FireAlarmEventArgs e );

   //Cria uma referencia de evento delegado
   public event FireAlarmEventHandler FireAlarm;

   public SmokeDetector( string location )
   {
      this.location = location;
      Console.WriteLine( "Smoke detector installed at " + location );
   }
   //Chama o cuidadores de eventos se o delegate nao vazio, 
   //argumento de evento de objeto passado por parametro
   protected void OnFireAlarm( FireAlarmEventArgs e )
   {
	  //FireAlarm e a referencia de delegate - tenha certeza que nao esteja vazio
      if ( FireAlarm != null )
	  {
         FireAlarm( this, e ); //passa o lancadir e os argumentos do evento
	  }
   }

   //Cria objeto de evento, passa para OnFireAlarm
   public void Alarm()
   {
      Console.WriteLine( "Smoke alarm at " + location );
      FireAlarmEventArgs e = new FireAlarmEventArgs( location );
      OnFireAlarm( e );
   }

} // finaliza classe SmokeDetector
	
//Classe Firedepartment rigistra um cuidador de evento e responde quando o evento ocorre
class FireDepartment 
{
   SmokeDetector smokeDetector;
   
   public FireDepartment( SmokeDetector smokeDetector )
   {
      this.smokeDetector = smokeDetector;
      
	  //Rigistra metodo de Respond como um cuidador de evento
      smokeDetector.FireAlarm += new SmokeDetector.FireAlarmEventHandler( Respond );
      
      Console.WriteLine( "Smoke detector registered " + "at fire department" );
   }

   //Metodo assinatura confirma delegate
   private void Respond( object sender, FireAlarmEventArgs e )
   {
      Console.WriteLine( "Fire department responding to alarm at "  + e.Location + ", we are on our way!" );
   }

}  //Finaliza classe FireDepartment

//Motorista
class EventExample
{
   static void Main( string[] args )
   {
	  //Cria um novo detector de fumaca
      SmokeDetector smokeDetector = new SmokeDetector( "102 East Main St." );
      
	  //Adiciona ao departamento de incendio
      FireDepartment fireDepartment = new FireDepartment( smokeDetector );
      
      smokeDetector.Alarm();  // chama evento Alarm
      Console.ReadLine();     // Atrasa saida do programa
   }
} // finaliza classe EventExample

/*
	Esse programa tem como finalidade mostrar como funciona os eventos em C#, para isso foi criado uma classe
	Departamento de incendio. Com isso e criado um evento que sera chamado quando ocorrer um incendio. Com isso
	caso ocorra o invencio, o delegate ira passar a funcao responsavel para tratar quando o evento ocorrer. Com isso
	caso o evento ocorra o delegate passa a funcao que ira realizar as medidas corretas para tratar esse evento.
*/

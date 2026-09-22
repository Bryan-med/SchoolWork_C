using System;
namespace orientado_objetos
{
	//propiedad
	public class hijoConstru : PersonaConstructor
	{
		string madre;
		string padre;
//construcotr
		public hijoConstru(string n, string co, string cp, float a, string m, string p) : base(n,co,cp,a)
		{
			this.madre = m;
			this.padre = p;
		}
//metodo
		public void Llora()
		{
			Console.WriteLine("el we esta llorando");
		}
		//polimorfismo del metodo padre que implmenta el clase hijo 
        public override void Caminar(int velocidad)
        {
			base.Caminar(velocidad);
			Console.WriteLine("es un bebe y no puede caminar");

		}

        //getters
        public string Getmadre()
		{
			return madre;
		}
		public string Getpadre()
		{
			return padre;
		}
//setters
		public void Setmadre(string nombreMadre)
		{
			this.madre = nombreMadre;
		}

		public void Setpadre(string nombrePadre)
		{
			this.padre = nombrePadre;
		}


	}

}


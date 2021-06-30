# Trabajo Practico # 2

***
```
public class TP_numero2_grupo1
{
	public TP_numero2_grupo1()
	{
		Grupo = 1;
		ComisionGrupo = new Comision();
		IntegrantesDelGrupo = new List‹Integrante›();		
	}
	IntegrantesDelGrupo.Add (new Integrante("Gino Bartolucci"));
	IntegrantesDelGrupo.Add (new Integrante("Francisco Mendiburu"));
	IntegrantesDelGrupo.Add (new Integrante("Ignacio Bruzzesi"));
	IntegrantesDelGrupo.Add (new Integrante("Brenda Godoy"));
	
	ComisionGrupo.Comision = "3elec1";
	ComisionGrupo.Docentes = new Docente[
	"Ing. Porta Ezequiel",
	"Lic. Severino Guimpel Federico" ];
	
	
	private int _Grupo;
	public int Grupo
	{
		get { return _Grupo; }
		set { _Grupo = value; }
	}
	
	private Comision _ComisionGrupo;
	public Comision ComisionGrupo
	{
		get { return _ComisionGrupo; }
		set { _ComisionGrupo = value; }
	}
	
	private List‹Integrante› _IntegrantesDelGrupo;
	public List‹Integrante› IntegrantesDelGrupo
	{
		get { return _IntegrantesDelGrupo; }
		set { _IntegrantesDelGrupo = value; }
	}
}
```
***

<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
//provjera da li je ispravna stanica:
$indeksStanice = intval($_GET["indeksStanice"]);
$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $indeksStanice))->dajImeStaniceResult;
if ($rezultat2 == "__GRESHKA__")
{
	echo "GREŠKA!<br />Odabrana stanica ne postoji.";
}
else
{
	//ako je ispravna stanica
	
	$rezultat = $soapClient->dajLinijeKrozStanicu(array('sifraStanice' => $indeksStanice))->dajLinijeKrozStanicuResult;
	
	$_x1_=get_object_vars($rezultat);
	if (!empty($_x1_))
	{
		echo "Linije kroz traženu stanicu:<br/><br/>";
		echo"<ul>";
		$rezultat = $rezultat->long;
		if (count($rezultat)==1)
		{
			$rezultatSada = $rezultat;
			echo "<li>";
			echo $soapClient->dajImeLinije(array('sifraLinije' =>$rezultatSada))->dajImeLinijeResult;
			echo "</li>";
		}
		else
		{
			for ($i=0;$i<count($rezultat);$i++)
			{
				$rezultatSada = $rezultat[$i];
				echo "<li>";
			echo $soapClient->dajImeLinije(array('sifraLinije' =>$rezultatSada))->dajImeLinijeResult;
			echo "</li>";
			}
		}
	}
	else
	{
		echo "Nažalost trenutno ne saobraća nijedna linija na datoj stanici.";
	}
	echo "<ul/>";
}

?>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
//provjera da li je ispravna stanica:
$indeksLinije = intval($_GET["indeksLinije"]);
$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $indeksLinije))->dajImeLinijeResult;
if ($rezultat2 == "__GRESHKA__")
{
	echo "GREŠKA!<br />Odabrana linija ne postoji.";
}
else
{
	//ako je ispravna stanica
	
	$rezultat3 = $soapClient->dajVoznje(array('sifraLinije' => $indeksLinije))->dajVoznjeResult;
	$_x1_=get_object_vars($rezultat3);
	echo "Vožnje na odabranoj liniji<br /><br />";
	echo "<ul>";
	if (!empty($_x1_))
	{
		$rezultat3 = $rezultat3->long;
		if (count($rezultat3)==1)
		{
			$rezultatSada = $rezultat3;
			$rezultat4 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $rezultatSada));
			echo "<li>";
			echo $rezultat4->dajPodatkeVoznjeResult;
			echo "</li>";
		}
		else
		{
			for ($j=0;$j<count($rezultat3);$j++)
			{
				$rezultatSada = $rezultat3[$j];
				$rezultat4 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $rezultatSada));
				echo "<li>";
				echo $rezultat4->dajPodatkeVoznjeResult;
				echo "</li>";
			}
		}
	}
	else
	{
		echo "<li>Nažalost trenutno nije zakazana nijedna vožnja na datoj liniji.</li>";
	}
	echo "</ul>";
}

?>
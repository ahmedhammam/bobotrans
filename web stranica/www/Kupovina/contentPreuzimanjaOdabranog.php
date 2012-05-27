<form name="brisanje" action="brisiOdabrano.php" method="post">
<?php

function dajImeLinije($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $x));
	return $rezultat2->dajImeLinijeResult;
}

function dajImeVoznje($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $x));
	return $rezultat2->dajPodatkeVoznjeResult;
}

function dajSpisakSjedista($x)
{
	$sada="";
	if (!empty($x))
	{
		$sada=$sada.sprintf("%d",$x[0]);
		for ($t=1;$t<count($x);$t++)
		{
			$sada=$sada.sprintf(", %d",$x[$t]);
		}
	}
	return $sada;
}

function dajCijenu($x)
{
	return sprintf("%.2f KM",$x);
}

function dajBrisanje($x)
{
	return sprintf("<input type='checkbox' name='Kupovina[]' value=%d />",$x);
}

function dajImeStanice($x)
{
	$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $x));
	return $rezultat2->dajImeStaniceResult;
}

include("postavljanjeSesije.php");
//tabela sa svim kupovinama
if ($_SESSION['brojNarudzbi']>0)
{
	echo "<table border='1'>";
	echo "<tr><th>Linija</th><th>Vožnja</th><th>Početna stanica</th><th>Krajnja stanica</th><th>Sjedišta</th><th>Cijena</th><th>Brisanje</th></tr>";
	
	for ($i=0;$i<$_SESSION['brojNarudzbi'];$i++)
	{
		echo sprintf("<tr><td>%s</td><td>%s</td><td>%s</td><td>%s</td><td>%s</td><td>%s</td><td align='center'>%s</td></tr>",
		dajImeLinije($_SESSION['narudzbe'][$i]["Linija"]),
		dajImeVoznje($_SESSION['narudzbe'][$i]["Voznja"]),
		dajImeStanice($_SESSION['narudzbe'][$i]["sifraPocetneStanice"]),
		dajImeStanice($_SESSION['narudzbe'][$i]["sifraKrajnjeStanice"]),
		dajSpisakSjedista($_SESSION['narudzbe'][$i]["Sjedista"]),
		dajCijenu($_SESSION['narudzbe'][$i]["Cijena"]),dajBrisanje($i));
	}
	
	
	echo "</table>";
}
else
{
	echo "<p>Niste odabrali nikakve karte za kupovinu</p>";
}
?>
<input type="submit" value="Briši" />
</form>
<form name="vracanjeNazad" action="index.php" method="post">
<input type="submit" value="Nastavi kupovati" />
</form>
<?php
if ($_SESSION['brojNarudzbi']>0)
{

include("formaZaPlacanje.php");

}
?>
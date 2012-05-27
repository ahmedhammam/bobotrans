<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $_REQUEST["Linija"]));
	echo "<p>Linija: ";
	echo $rezultat2->dajImeLinijeResult;
	echo "</p>";
?>
<p>Odaberite vožnju i stanice:</p>

<form name="odabirOstalog" action="biranjeKarte.php" method="post">
<input type="hidden" name="Linija" value=<?php echo $_REQUEST["Linija"]; ?> />
<select name="Voznja">
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat3 = $soapClient->dajVoznje(array('sifraLinije' => $_REQUEST["Linija"]))->dajVoznjeResult;
	$_x1_=get_object_vars($rezultat3);
	if (!empty($_x1_))
	{
		$rezultat3 = $rezultat3->long;
		if (count($rezultat3)==1)
		{
			$rezultatSada = $rezultat3;
			$rezultat4 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $rezultatSada));
			echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajPodatkeVoznjeResult);
		}
		else
		{
			for ($j=0;$j<count($rezultat3);$j++)
			{
				$rezultatSada = $rezultat3[$j];
				$rezultat4 = $soapClient->dajPodatkeVoznje(array('sifraVoznje' => $rezultatSada));
				echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajPodatkeVoznjeResult);
			}
		}
	}

?>
</select>
<br />
<select name="Stanica1">
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat3 = $soapClient->dajStaniceULiniji(array('sifraLinije' => $_REQUEST["Linija"]))->dajStaniceULinijiResult;
	$_x1_=get_object_vars($rezultat3);
	if (!empty($_x1_))
	{
		$rezultat3 = $rezultat3->long;
		if (count($rezultat3)==1)
		{
			$rezultatSada = $rezultat3;
			$rezultat4 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultatSada));
			echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajImeStaniceResult);
		}
		else
		{
			for ($j=0;$j<count($rezultat3);$j++)
			{
				$rezultatSada = $rezultat3[$j];
				$rezultat4 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultatSada));
				echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajImeStaniceResult);
			}
		}
	}

?>
</select>
<br />
<select name="Stanica2">
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
	$rezultat3 = $soapClient->dajStaniceULiniji(array('sifraLinije' => $_REQUEST["Linija"]))->dajStaniceULinijiResult;
	$_x1_=get_object_vars($rezultat3);
	if (!empty($_x1_))
	{
		$rezultat3 = $rezultat3->long;
		if (count($rezultat3)==1)
		{
			$rezultatSada = $rezultat3;
			$rezultat4 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultatSada));
			echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajImeStaniceResult);
		}
		else
		{
			for ($j=0;$j<count($rezultat3);$j++)
			{
				$rezultatSada = $rezultat3[$j];
				$rezultat4 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultatSada));
				echo sprintf("<option value=%d>%s</option>",$rezultatSada,$rezultat4->dajImeStaniceResult);
			}
		}
	}

?>
</select>
<br />
<input type="submit" value="Dalje" />
</form>

<form name="vracanjeNazad" action="biranjeKarte.php" method="post">
<input type="submit" value="Nazad" />
</form>
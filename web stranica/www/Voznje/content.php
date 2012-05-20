Trenutno zakazane vožnje:
<br />
<br />
<ul>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$rezultat = $soapClient->dajLinije()->dajLinijeResult->long;
for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $rezultat[$i]));
	echo "<li>";
	echo $rezultat2->dajImeLinijeResult;
	echo "</li>";
	$rezultat3 = $soapClient->dajVoznje(array('sifraLinije' => $rezultat[$i]))->dajVoznjeResult;
	$_x1_=get_object_vars($rezultat3);
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
</ul>
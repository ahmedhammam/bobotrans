<p>Odaberite liniju:</p>
<form name="odabirLinije" action="biranjeKarte.php" method="post">
<select name="Linija">

<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$rezultat = $soapClient->dajLinije()->dajLinijeResult->long;
for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $rezultat[$i]));
	echo sprintf("<option value=%d>%s</option>",$rezultat[$i],$rezultat2->dajImeLinijeResult);
}

?>

<!--<option value=1>PRVA</option>
<option value=2>DRUGA</option>
<option value=3>TRECA</option>-->
</select>
<br />
<input type="submit" value="Dalje" />
</form>
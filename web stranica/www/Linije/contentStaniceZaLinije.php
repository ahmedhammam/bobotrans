Odaberite liniju za koju želite saznati kroz koje stanice prolazi:
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
	echo sprintf("<a href='staniceNaLiniji.php?indeksLinije=%d'>",$rezultat[$i]);
	echo $rezultat2->dajImeLinijeResult;
	echo "</a>";
	echo "</li>";
}

?>
</ul>
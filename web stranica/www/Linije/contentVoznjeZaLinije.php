Odaberite liniju za koju želite saznati koje vožnje su na njoj zakazane:
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
	echo sprintf("<a href='voznjeNaLiniji.php?indeksLinije=%d'>",$rezultat[$i]);
	echo $rezultat2->dajImeLinijeResult;
	echo "</a>";
	echo "</li>";
}

?>
</ul>
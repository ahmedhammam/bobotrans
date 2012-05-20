Odaberite stanicu za koju želite saznati koje linije kroz nju prolaze:
<br />
<br />
<ul>
<?php
$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$rezultat = $soapClient->dajStanice()->dajStaniceResult->long;
for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeStanice(array('sifraStanice' => $rezultat[$i]));
	echo "<li>";
	echo sprintf("<a href='linijeKrozStanicu.php?indeksStanice=%d'>",$rezultat[$i]);
	echo $rezultat2->dajImeStaniceResult;
	echo "</a>";
	echo "</li>";
}

?>
</ul>
<p>Odaberite sjedišta (zelena su slobodna, a crvena zauzeta):</p>
<form name="odabirLinije" action="zauzimanjeSjedista.php" method="post">
<input type="hidden" name="Linija" value=<?php echo $_REQUEST["Linija"]; ?> />
<input type="hidden" name="Voznja" value=<?php echo $_REQUEST["Voznja"]; ?> />
<input type="hidden" name="Stanica1" value=<?php echo $_REQUEST["Stanica1"]; ?> />
<input type="hidden" name="Stanica2" value=<?php echo $_REQUEST["Stanica2"]; ?> />

<?php

function iscrtaj($a,$b)
{
	if ($b)
	{
		echo "<td align='center' style='background-color:#7CFC00'>";
		echo sprintf("<input type='checkbox' name='Sjediste[]' value=%d />%d",$a+1,$a+1);
		echo "</td>";
	}
	else
	{
		echo "<td align='center' style='color:#FFFFFF; background-color:#8B0000'>";
		echo sprintf("%d",$a+1);
		echo "</td>";
	}
}

$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
$broj_sjedista = $soapClient->dajBrojSjedistaBusa(array('sifraVoznje'=>$_REQUEST['Voznja']))->dajBrojSjedistaBusaResult;
$sjedista = $soapClient->dajSlobodnaSjedista(array('sifraLinije'=>$_REQUEST['Linija'],'sifraVoznje'=>$_REQUEST['Voznja'],'sifraPocetneStanice'=>$_REQUEST['Stanica1'],'sifraKrajnjeStanice'=>$_REQUEST['Stanica2']))->dajSlobodnaSjedistaResult->boolean;
$brojmalihredova=($broj_sjedista-5)/4;
echo "<table width=300 style='table-layout:fixed'>";
echo "<tr>";
iscrtaj($brojmalihredova*4,$sjedista[$brojmalihredova*4]);
iscrtaj($brojmalihredova*4+1,$sjedista[$brojmalihredova*4+1]);
iscrtaj($brojmalihredova*4+2,$sjedista[$brojmalihredova*4+2]);
iscrtaj($brojmalihredova*4+3,$sjedista[$brojmalihredova*4+3]);
iscrtaj($brojmalihredova*4+4,$sjedista[$brojmalihredova*4+4]);
echo "</tr>";
for ($i=$brojmalihredova-1;$i>-1;$i--)
{
	echo "<tr>";
	iscrtaj($i*4,$sjedista[$i*4]);
	iscrtaj($i*4+1,$sjedista[$i*4+1]);
	echo "<td></td>";
	iscrtaj($i*4+2,$sjedista[$i*4+2]);
	iscrtaj($i*4+3,$sjedista[$i*4+3]);
	echo "</tr>";
}

echo "</table>";
/*for ($i=0;$i<count($rezultat);$i++)
{
	$rezultat2 = $soapClient->dajImeLinije(array('sifraLinije' => $rezultat[$i]));
	echo sprintf("<option value=%d>%s</option>",$rezultat[$i],$rezultat2->dajImeLinijeResult);
}*/

?>


<input type="submit" value="Dalje" />
</form>

<form name="vracanjeNazad" action="biranjeKarte.php" method="post">
<input type="hidden" name="Linija" value=<?php echo $_REQUEST["Linija"]; ?> />
<input type="submit" value="Nazad" />
</form>
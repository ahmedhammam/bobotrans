<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<?php

include("postavljanjeSesije.php");

?>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

<?php

function provjeraKarticeVISA()
{
	return 0;
}
function provjeraKarticeMasterCard()
{
	return 0;
}
function provjeraKarticeAmericanExpress()
{
	return 0;
}
function provjeraKartice()
{
	if ($_POST['tip']=="VISA") return provjeraKarticeVISA();
	else if ($_POST['tip']=="MasterCard") return provjeraKarticeMasterCard();
	else if ($_POST['tip']=="American Express") return provjeraKarticeAmericanExpress();
	else return 1;
}

function oduzmiNovac($x)
{
	
}

function generisiKod()
{
	$kod="";
	for ($ii=0;$ii<10;$ii++)
	{
		$sljedeci = rand(0,35);
		if ($sljedeci<10) $kod = $kod.chr($sljedeci+ord("0"));
		else $kod = $kod.chr($sljedeci-10+ord("A"));
	}
	return $kod;
}

function provjeriDaLiJeSlobodno($i)
{
	//provjera slobodnosti sjedista
	return true;
}

$provjera = provjeraKartice();
if ($provjera==0)
{
	$_SESSION['kodovi']=array();
	for ($i=0;$i<$_SESSION['brojNarudzbi'];$i++)
	if (provjeriDaLiJeSlobodno($i))
	{
		$sadasnjiSubmit=array(
		'imeKupca'=>$_POST['ime'],
		'sifraLinije'=>$_SESSION['narudzbe'][$i]['Linija'],
		'sifraVoznje'=>$_SESSION['narudzbe'][$i]['Voznja'],
		'sifraPocetneStanice'=>$_SESSION['narudzbe'][$i]['sifraPocetneStanice'],
		'sifraKrajnjeStanice'=>$_SESSION['narudzbe'][$i]['sifraKrajnjeStanice'],
		'sjedista'=>$_SESSION['narudzbe'][$i]['Sjedista'],
		'kod'=>generisiKod()
		);
		oduzmiNovac($i);
		array_push($_SESSION['kodovi'],$sadasnjiSubmit);
		$soapClient = new SoapClient("http://localhost:3596/InternetServisi.asmx?WSDL");
		$soapClient->dodajKupca($sadasnjiSubmit);
	}
	unset($_SESSION['brojNarudzbi']);
	unset($_SESSION['narudzbe']);
	header("location: ishod.php?status=0");
}
else
{
	header(sprintf("location: ishod.php?status=%d",$provjera));
}


?>


</head>

<body>
</body>
</html>
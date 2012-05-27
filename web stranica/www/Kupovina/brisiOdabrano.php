<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<?php

include("postavljanjeSesije.php");

?>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<?php

function prolazi($x)
{
	for ($k=0;$k<count($_POST['Kupovina']);$k++)
	{
		if ($_POST['Kupovina'][$k]==$x) return false;
	}
	return true;
}

if (isset($_POST['Kupovina']))
{
	$privremeni = array();
	$brojNar = 0;
	for ($i=0;$i<$_SESSION['brojNarudzbi'];$i++)
	if (prolazi($i))
	{
		array_push($privremeni,$_SESSION['narudzbe'][$i]);
		$brojNar++;
	}
	$_SESSION['brojNarudzbi']=$brojNar;
	$_SESSION['narudzbe']=$privremeni;
}


header("location: preuzimanjeOdabranog.php");
?>
</head>

<body>
</body>
</html>
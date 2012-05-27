<?php

if (!isset($_SESSION)) {
  session_start();
}
if (!isset($_SESSION['brojNarudzbi']))
{
	$_SESSION['brojNarudzbi']=0;
	$_SESSION['narudzbe']=array();
}

?>
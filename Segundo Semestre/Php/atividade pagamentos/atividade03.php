<?php
$forma_pag = $_POST['forma_pag'];
$val_Compra = $_POST['val_Compra'];

if(trim($val_Compra)==""){
    echo "Digite o valor da venda";
}


if ($forma_pag == "a_vista")
{
    $val_Compra =$val_Compra - $val_Compra*0.05;
    echo "O Valor da Compra é : " .number_format ($val_Compra, 2, ',' , '.');
} 

else if ($forma_pag == "a_prazo")
{
    $val_Compra += $val_Compra* 0.12;
    echo "O Valor da Compra é : " .number_format ($val_Compra, 2, ',' , '.');
}
    



?>
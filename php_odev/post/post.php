<?php
error_reporting(E_ALL);

$sayi = $_POST['sayi'];

if ($sayi == "") {
    echo "lütfen sayı değeri giriniz";
} else if ($sayi % 3 == 0) echo "sayı 3' e bölünebilir";
else{
    while($sayi % 3 != 0){
        $sayi++;
    }
    echo "sayı 3' e bölünemez, en yakın sayı $sayi";
}

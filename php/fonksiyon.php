<?php
function ucgen (int $sayi = 5){
    for ($i=0; $i < $sayi; $i++){
        $a = 0;
        while($a<=$i){
            echo "*";
            $a++;
        }
        echo "<br>";
    }
}
ucgen(/*deger*/);

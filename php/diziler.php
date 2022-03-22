<?php
echo "<pre>";
$ilkdizi = ['film', 'dizi', 'kitap', '', null, 'belgesel', '', 'yürüyüş', 'yatış', NULL, 'tatlı'];
function duzelt(array $d, int $i){
        return array_map(function(int $a){
        global $ilkdizi;
        return $ilkdizi[$a];
    }, array_rand(array_filter($d),$i));;
}

print_r(duzelt($ilkdizi, 5));

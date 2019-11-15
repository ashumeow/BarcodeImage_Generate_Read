<?php

$url = 'https://chart.googleapis.com/chart?chs=300x300&cht=qr&chl=hello.i.am.ashu&choe=UTF-8';
$img = "C:\meow\barcodes\sample.png";
file_put_contents($img, file_get_contents($url));

echo "File written into the directory";

// ashumeow

?>
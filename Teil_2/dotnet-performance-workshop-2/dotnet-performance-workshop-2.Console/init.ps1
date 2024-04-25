$url = "https://data.scryfall.io/oracle-cards/oracle-cards-20240425090207.json"
$dest = "oracle-cards-20240425090207.json"

Invoke-WebRequest -Uri $url -OutFile $dest

EndPoint (curl) para registrar INGREDIENTE

curl --location 'https://localhost:7145/api/Ingrediente/create' \
--header 'Content-Type: application/json' \
--data '{
    "Nombre": "Jamon",
    "Precio": 3.50
}'

EndPoint (curl) para registrar PIZZA

curl --location 'https://localhost:7145/api/pizza/create' \
--header 'Content-Type: application/json' \
--data '{
    "Nombre": "Stroggonoff",
    "EsPersonalizada": false,
    "Precio_Base": 12.99
}'

EndPoint (curl) para registrar PEDIDO

curl --location 'https://localhost:7145/api/pedido/create' \
--header 'Content-Type: application/json' \
--data '{
    "ID_Cliente": 1,
    "Fecha_Pedido": "2024-11-13T12:00:00",
    "Costo_Total": 25.50,
    "Delivery_Incluido": false,
    "Promocion_2x1_Aplicada": true,
    "Estado": "En proceso"
}'

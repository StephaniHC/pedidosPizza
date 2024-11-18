1. Registrar Ingrediente
    Descripción
    Este endpoint permite registrar un nuevo ingrediente en el sistema.
    
    Endpoint
    POST /api/Ingrediente/create
    
    Request Body
    json
    {
      "Nombre": "Jamon",
      "Precio": 3.50
    }
    Campos
    Nombre (string): Nombre del ingrediente.
    Precio (decimal): Precio del ingrediente en la moneda local.

    Ejemplo de uso con cURL:
        curl --location 'https://localhost:7145/api/Ingrediente/create' \
        --header 'Content-Type: application/json' \
        --data '{
            "Nombre": "Jamon",
            "Precio": 3.50
        }'

   2. Registrar Pizza
    Descripción
    Este endpoint permite registrar una nueva pizza en el sistema.
    
    Endpoint
    POST /api/pizza/create
    
    Request Body
    json
    {
      "Nombre": "Stroggonoff",
      "EsPersonalizada": false,
      "Precio_Base": 12.99
    }
    Campos
    Nombre (string): Nombre de la pizza.
    EsPersonalizada (boolean): Indica si la pizza es personalizada.
    Precio_Base (decimal): Precio base de la pizza.
    Ejemplo de uso con cURL:
        curl --location 'https://localhost:7145/api/pizza/create' \
        --header 'Content-Type: application/json' \
        --data '{
            "Nombre": "Stroggonoff",
            "EsPersonalizada": false,
            "Precio_Base": 12.99
        }'

   3. Registrar Pedido
    Descripción
    Este endpoint permite registrar un nuevo pedido en el sistema.
    
    Endpoint
    POST /api/pedido/create
    
    Request Body
    json
    {
      "Fecha_Pedido": "2024-11-13T12:00:00",
      "Costo_Total": 25.50,
      "Delivery_Incluido": false,
      "Promocion_2x1_Aplicada": true,
      "Estado": "En proceso"
    }
    Campos
    ID_Cliente (integer): Identificador del cliente que realiza el pedido.
    Fecha_Pedido (string, ISO 8601): Fecha y hora del pedido.
    Costo_Total (decimal): Costo total del pedido.
    Delivery_Incluido (boolean): Indica si incluye el costo del delivery.
    Promocion_2x1_Aplicada (boolean): Indica si se aplicó la promoción 2x1.
    Estado (string): Estado actual del pedido.
    Ejemplo de uso con cURL:
        curl --location 'https://localhost:7145/api/pedido/create' \
        --header 'Content-Type: application/json' \
        --data '{
            "Fecha_Pedido": "2024-11-13T12:00:00",
            "Costo_Total": 25.50,
            "Delivery_Incluido": false,
            "Promocion_2x1_Aplicada": true,
            "Estado": "En proceso"
        }'

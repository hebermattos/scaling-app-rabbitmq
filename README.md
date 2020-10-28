# Microserviços & Rabbitmq

## No inicio...

Temos uma api de visualizacao de imagens, que no início era assim:

![api](./imagens/buscar-imagem-01.PNG)

Tudo ok. retorna uma imagem, bem simples ;)

## Novas features

Com a passagem do tempo, implementandos algumas features, basedas em rankings e recomendações:

![api](./imagens/buscar-imagem-02.PNG)

## Sinal amarelo!

Agora nossa chamada esta fazendo coisas que nao importam muito para o cliente, pelo menos não em *tempo real*. todas essas ações pode sem feitas de maneira *assincrona*, liberando a chamada na api para fazer quase exclusivamente o cliente esta pedindo: retornar uma imagem.

Removendo essas lógicas de "relatórios", deixamos a api mais performática para o cliente e removemos algum pontos de falhas na api. agora vamos começar a entrar no *microserviços*.

## RabbitMQ

Então, o que faremos?

Quando for solicitado uma imagem, vamos disperar um *evento* chamado *VisualizacaoImagem*. esse evento será enviado para o rabbitmq, e outro servico irá *consumir* essa evento, processando todas as regras que removemos do fluxo da api.

![api](./imagens/buscar-imagem-03.PNG)

nosso evento vai conter somente o ID da imagem (o nome no caso), que é o que nossos métodos precisam.

![api](./imagens/rabbitmq-01.PNG)



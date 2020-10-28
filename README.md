# por que usar rabbitmq? 

## no inicio...

temos uma api de visualizacao de imagens, que no início era assim:

![api](./imagens/buscar-imagem-01.PNG)

tudo ok. retorno uma imagem, bem simples ;)

## novas features

com a passagem do tempo, implementandos algumas features, basedas em rankings e recomendações:

![api](./imagens/buscar-imagem-02.PNG)

## sinal amarelo!

agora nossa chamada esta fazendo coisas que nao importam muito para o cliente, pelo menos não em *tempo real*. todas essas ações pode sem feitas de maneira *assincrona*, liberando a chamada na api para fazer quase exclusivamente o cliente esta pedindo: retornar uma imagem.

removendo essas lógicas de "relatórios", deixamos a api mais performática para o cliente e removemos algum pontos de falhas na api. agora vamos começar a entrar no *microserviços*

## rabbitmq
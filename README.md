# por que usar rabbitmq? 

## no inicio...

temos uma api de visualizacao de imagens, que no início era assim:

![api](./imagens/buscar-imagem-01.PNG)

tudo ok. retorno uma imagem, bem simples ;)

## novas features

com a passagem do tempo, implementandos algumas features, basedas em rankings e recomendações:

![api](./imagens/buscar-imagem-02.PNG)

## sinal amarelo!

agora nossa chamada esta fazendo coisas que nao importam muito para o cliente, pelo menos nao em *tempo real*. todas essas ações pode sem feitas de maneira *assincrona*, liberando a chamada na api para fazer quase exclusivamente o cliente esta pedindo: retornar uma imagem.
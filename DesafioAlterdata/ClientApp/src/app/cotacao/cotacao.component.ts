import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DecimalPipe } from '@angular/common';

@Component({
  selector: 'app-cotacao',
  templateUrl: './cotacao.component.html'
})
export class CotacaoComponent {
  public cotacoes: Cotacao;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Resultado>(baseUrl + 'cotacao').subscribe(result => {
      debugger;
      this.cotacoes = result.resultados;
    }, error => console.error(error));
  }
}

interface Resultado{
  resultados: Cotacao
}

interface Cotacoes{
  cotacoes: Cotacao
}

interface Cotacao{
  dolar: Moeda,
  euro: Moeda,
  bitcoin: Moeda
}

interface Moeda{
  nome: string,
  valorCompra: number,
  valorVenda: number,
  variacaoPercentual: number
}
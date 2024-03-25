## README.md para a Aplicação de Informações da Bateria

**Descrição:**

Esta aplicação demonstra como obter informações detalhadas sobre a bateria do sistema usando a WMI (Windows Management Instrumentation).

**Funcionalidades:**

* Exibe informações sobre a bateria, como:
    * Status da bateria (carregando, descarregando, etc.)
    * Nível de carga da bateria
    * Tempo restante de carga/descarga
    * Capacidade da bateria
    * Tipo de química da bateria
    * E muito mais!
* Suporta diferentes tipos de baterias, como:
    * Íon de lítio
    * Polímero de lítio
    * Níquel-metal hidreto
    * Níquel-cádmio
    * Chumbo-ácido

**Como usar:**

1. Execute o aplicativo `BatteryInformation.exe`.
2. As informações da bateria serão exibidas na tela.

**Observações:**

* Este aplicativo foi desenvolvido para Windows.
* As informações da bateria podem variar dependendo do tipo de bateria e do sistema operacional.

**Recursos Adicionais:**

* Documentação da WMI: [Microsoft](https://learn.microsoft.com/pt-br/windows/win32/cimwin32prov/win32-provider)
* Classes WMI para baterias: [GitHub](https://github.com/MicrosoftDocs/win32/blob/docs/desktop-src/CIMWin32Prov/win32-battery.md)

**Exemplo de Saída:**

```
Disponibilidade: Em Execução/Potência Total
Tempo de Recarga da Bateria: 120 minutos
Status da Bateria: Carregando
Descrição: Bateria do Sistema
Química: Íon de Lítio
Capacidade de Design: 50000 mWh
Tensão de Design: 11400 mV
ID do Dispositivo: ACPI\BATT0001
Tempo Estimado de Execução: 240 minutos
Capacidade de Carga Total: 45000 mWh
Carga Estimada Restante: 80%
Vida Útil Estimada: 600 minutos
Tempo Máximo de Recarga: 120 minutos
Nome: Bateria do Sistema
ID do Dispositivo PnP: *PNP030b
Capacidades de Gerenciamento de Energia:
    - Desativado
    - Suporta Ciclos de Energia
    - Suporta Alertas de Nível Baixo de Bateria
    - Suporta Alertas de Nível Crítico de Bateria
    - Suporta Modos de Economia de Energia
Versão da Bateria Inteligente: 1.1.0
Status: OK
Informações de Status: Ativado
Nome da Classe de Criação do Sistema: ACPI
Nome do Sistema: DESKTOP-ABCDEFG
Tempo na Bateria: 7200 segundos
Tempo para Carga Completa: 60 minutos
```

**Comentários e Sugestões:**

Sinta-se à vontade para enviar seus comentários e sugestões para melhorar este aplicativo.

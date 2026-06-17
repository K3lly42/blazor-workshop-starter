# Restaurant App

Das **Frontend** des Restaurant-Workshops: eine **.NET 10 Blazor Web App** mit
**MudBlazor**, die Restaurants und Bewertungen anzeigt. Die Daten kommen von der
[Restaurant API](https://api.bigfoot-htcu.com).

## Auf einen Blick

| Eigenschaft     | Wert                                                  |
| --------------- | ----------------------------------------------------- |
| Framework       | .NET 10, Blazor Web App (`InteractiveServer`)         |
| UI              | MudBlazor 9.x                                          |
| API-Anbindung   | Typed `HttpClient` (`RestaurantApiService`)            |
| Konsumierte API | [restaurant-api](https://api.bigfoot-htcu.com/scalar/v1) |
| Repository      | `K3lly42/blazor-workshop-starter`                      |

## Zweck

Dieses Projekt ist der **Workshop-Starter**: die Infrastruktur (MudBlazor, HttpClient,
DTOs, Routing, Scaffolding) ist vorverdrahtet, sodass sich Teilnehmende auf die
Blazor-Mechanik konzentrieren können. Die zu implementierenden Teile sind in den
jeweiligen Dateien als `TODO`-Blöcke markiert (siehe [Entwicklung](development.md)).

## Verbindung zur API

Die App spricht ausschließlich die **Restaurant API** an:

- **Base URL:** <https://api.bigfoot-htcu.com>
- **API-Doku (Scalar):** <https://api.bigfoot-htcu.com/scalar/v1>

In Backstage ist diese Beziehung über `consumesApis: [restaurant-api]` hinterlegt –
auf der API-Seite erscheint die App entsprechend als Consumer.

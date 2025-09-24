# IDED_Scripting_202510_P2
Solución del parcial 2 de Scripting.
### Integrantes
- Simara Villasmil - 000509719
- Esteban Puerta - 000509157
- Valeria Cecilia Blanquicett - 000501665

# Taller 2 - Scripting (UPB)

## 👨‍💻 Integrantes
- [Tu Nombre Aquí]

---

## 📖 Descripción
Este proyecto implementa un sistema simplificado de combate tipo Pokémon, siguiendo el enfoque **Desarrollo Dirigido por Pruebas (TDD)**.

Incluye:
- Clases base (`Pokemon`, `Move`, `TypeChart`, `DamageCalculator`).
- 5 especies de Pokémon implementadas como clases concretas (`Pikachu`, `Charmander`, `Bulbasaur`, `Onix`, `Gastly`).
- Fórmula de cálculo de daño según nivel, estadísticas, poder de movimiento y modificadores por tipo.
- Pruebas unitarias con NUnit cubriendo:
  - Inicialización de objetos.
  - Tabla de efectividades de tipo (`TypeChart`).
  - Fórmula de daño (`DamageCalculator`) con **40 casos exactos** dados por el profesor.

---

## 🛠️ Tecnologías
- C# (.NET 6 / .NET Core)
- NUnit
- NUnit3TestAdapter
- Visual Studio 2022

---

##  Ejecución de pruebas

Para correr las pruebas, no se ejecuta el programa con `Ctrl + F5`.  
En su lugar se debe usar el **Explorador de pruebas (Test Explorer)** en Visual Studio:

1. Abrir `Explorador de pruebas`:
   - Menú **Prueba** → **Explorador de pruebas**  
   - O atajo: `Ctrl + E, T`  

2. Compilar el proyecto de pruebas.  

3. En el Explorador se listan todas las pruebas (`PokemonTests`, `MoveTests`, `TypeChartTests`, `DamageCalculatorTests`).  

4. Para ejecutarlas:
   - Clic en **Ejecutar todo** (`Run All Tests`).  
   - O clic derecho en una prueba específica → **Ejecutar**.  

5. Interpretar resultados:
   - ✅ Verde = la prueba pasó correctamente.  
   - ❌ Rojo = la prueba falló (compila, pero el valor no coincide con lo esperado).  
   - ⚪ Gris = prueba aún no ejecutada.  

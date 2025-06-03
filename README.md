# NodeLab

<div align="center">

![NodeLab Logo](https://img.shields.io/badge/NodeLab-v1.0-blue?style=for-the-badge&logo=visual-studio&logoColor=white)

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-purple?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/Windows%20Forms-GUI-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019+-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)](https://visualstudio.microsoft.com/)

[![License](https://img.shields.io/badge/License-MIT-green?style=flat-square)](LICENSE)
[![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey?style=flat-square&logo=windows)](https://www.microsoft.com/windows/)
[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

**Приложение Windows Forms для интерактивной работы с циклическими двусвязными списками**

</div>

---

## 📋 Содержание

- [🚀 Введение](#-введение)
- [✨ Возможности](#-возможности)
- [⚡ Установка](#-установка)
- [🎯 Использование](#-использование)
  - [Основное меню](#основное-меню)
  - [Создание списка](#создание-списка)
  - [Редактирование списка](#редактирование-списка)
- [📁 Структура проекта](#-структура-проекта)
- [🔧 Зависимости](#-зависимости)
- [⚙️ Конфигурация](#️-конфигурация)
- [💡 Примеры](#-примеры)
- [🐛 Устранение неполадок](#-устранение-неполадок)
- [🏗️ Особенности реализации](#️-особенности-реализации)

---

## 🚀 Введение

NodeLab помогает пользователям понять принципы работы с циклическими двусвязными списками через интуитивно понятный графический интерфейс. Приложение предоставляет полный набор операций для манипулирования структурой данных, включая создание, вставку, удаление элементов и выполнение специальных задач.

<div align="center">

**🎓 Идеально подходит для изучения структур данных**

</div>

---

## ✨ Возможности

<table>
<tr>
<td>

### 📋 Создание списков
- Создание циклического двусвязного списка из массива чисел
- Валидация входных данных

</td>
<td>

### ➕ Добавление элементов
- Вставка в начало списка
- Вставка в конец списка
- Вставка в произвольную позицию

</td>
</tr>
<tr>
<td>

### ❌ Удаление элементов
- Удаление первого элемента
- Удаление последнего элемента
- Удаление элемента по позиции

</td>
<td>

### 🎯 Специальные функции
- Удаление элементов между двумя значениями
- Визуализация содержимого списка
- Обработка ошибок и валидация

</td>
</tr>
</table>

---

## ⚡ Установка

### Требования
![Windows](https://img.shields.io/badge/Windows-10/11-0078D6?style=flat&logo=windows&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20Framework-4.7.2+-512BD4?style=flat&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019+-5C2D91?style=flat&logo=visual-studio&logoColor=white)

### Шаги установки

```bash
# 1. Клонируйте репозиторий
git clone <repository-url>
cd NodeLab
```

```bash
# 2. Откройте в Visual Studio и соберите проект
# Ctrl+Shift+B
```

```bash
# 3. Запустите приложение
# F5
```

---

## 🎯 Использование

### Основное меню

После запуска приложения используйте главное меню для доступа к функциям:

| Раздел | Функция | Описание |
|--------|---------|----------|
| **Задания** | Создать список | Создание нового списка из чисел |
| **Задания** | Редактировать список | Добавление/удаление элементов |
| **Задания** | Основная задача | Удаление элементов между границами |
| **Задания** | Разрушить список | Полная очистка списка |
| **Выход** | - | Завершение работы приложения |

### Создание списка

> **Пример:** `1 2 3 4 5`

1. 📋 Выберите "Создать список" в меню
2. ✏️ Введите числа через пробел
3. ✅ Нажмите "OK" для создания списка

### Редактирование списка

1. 🔍 Убедитесь, что список создан
2. 🎯 Выберите соответствующую операцию в меню
3. 📝 Введите необходимые данные в диалоговом окне
4. 📊 Результат будет отображен в новом окне

---

## 📁 Структура проекта

```
NodeLab/
├── 📄 About.cs                    # Компонент информации о программе
├── 🏠 Main.cs                     # Главная форма приложения
├── 🔗 Node.cs                     # Классы DoubleNode и CycleDoubleLinkedList
├── 📋 CreateListForm.cs           # Форма создания списка
├── 🖨️ PrintListForm.cs            # Форма отображения списка
├── ➕ AddElement/                 # Формы добавления элементов
│   ├── InsertFirstForm.cs
│   ├── InsertLastForm.cs
│   └── InsertCustomForm.cs
├── ❌ DeleteElement/              # Формы удаления элементов
│   └── DeleteCustomForm.cs
└── 🎯 MainTask/                   # Основная задача
    └── MainTaskForm.cs
```

---

## 🔧 Зависимости

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-512BD4?style=for-the-badge&logo=dotnet)
![Windows Forms](https://img.shields.io/badge/System.Windows.Forms-Built--in-blue?style=for-the-badge)
![System.Drawing](https://img.shields.io/badge/System.Drawing-Built--in-green?style=for-the-badge)

**Внешние пакеты NuGet не требуются**

</div>

---

## ⚙️ Конфигурация

> 🎛️ **Простота использования:** Приложение не требует дополнительной конфигурации. Все настройки встроены в пользовательский интерфейс.

---

## 💡 Примеры

### Создание списка программно

```csharp
// Инициализация списка
CycleDoubleLinkedList list = new CycleDoubleLinkedList();
int[] data = {1, 2, 3, 4, 5};
list.Create(data);
```

### Добавление элементов

```csharp
// ➕ Добавить в начало
list.InsertBeforeFirst(10);

// ➕ Добавить в конец
list.InsertLast(20);

// ➕ Добавить в позицию
list.InsertCustom(15, 3, out string error);
```

### Удаление элементов

```csharp
// ❌ Удалить первый элемент
list.DeleteFirst();

// ❌ Удалить последний элемент
list.DeleteLast();

// 🎯 Удалить элементы между значениями
list.DeleteBetween(2, 8, out string error);
```

### Поиск элемента

```csharp
// 🔍 Поиск элемента
DoubleNode found = list.Find(5);
if (found != null)
{
    Console.WriteLine($"Найден элемент: {found.Info}");
}
```

---

## 🐛 Устранение неполадок

<details>
<summary><strong>🔧 Общие ошибки</strong></summary>

| Ошибка | Причина | Решение |
|--------|---------|---------|
| ❌ "Неверная позиция" | Позиция ≤ 0 | Убедитесь, что позиция больше 0 |
| ❌ "Позиция вне диапазона" | Позиция > размер списка | Проверьте размер списка |
| ❌ "Ошибка ввода" | Нечисловые данные | Вводите только целые числа |
| ❌ "Список пуст" | Операция на пустом списке | Создайте список перед операциями |

</details>

<details>
<summary><strong>🎯 Основная задача - специфические ошибки</strong></summary>

| Ошибка | Описание |
|--------|----------|
| ❌ "Левая граница не найдена" | Первое значение отсутствует в списке |
| ❌ "Правая граница не найдена" | Второе значение отсутствует в списке |
| ❌ "Между границами нет элементов" | Граничные элементы находятся рядом |
| ❌ "Правая граница должна находиться после левой" | Неверный порядок границ |

</details>

---

## 🏗️ Особенности реализации

### Циклический двусвязный список

<div align="center">

```
┌─────┐    ┌─────┐    ┌─────┐    ┌─────┐
│HEAD │◄──►│  1  │◄──►│  2  │◄──►│  3  │
│     │    │     │    │     │    │     │
└─────┘    └─────┘    └─────┘    └─────┘
   ▲                                 │
   └─────────────────────────────────┘
```

</div>

**Ключевые особенности:**
- 🔄 Использует фиктивный головной узел (`head`)
- 🔁 Последний элемент указывает на `head`
- ↔️ Поддерживает двунаправленную навигацию

### Класс DoubleNode

```csharp
public class DoubleNode
{
    public int Info { get; set; }        // 📊 Данные узла
    public DoubleNode Next { get; set; } // ➡️ Следующий узел
    public DoubleNode Prev { get; set; } // ⬅️ Предыдущий узел
}
```

---

<div align="center">

*Сделано с ❤️ для изучения структур данных*

</div>

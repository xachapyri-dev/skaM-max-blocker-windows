<div align="center">

# Проект закрыт
  
</div>

Причина: Не пользуется спросом

# 🛑 Anti-MAX Blocker (skaM) для Windows

[![GitHub release (latest by date)](https://img.shields.io/github/v/release/xachapyri-dev/skaM-max-blocker-windows)](https://github.com/xachapyri-dev/skaM-max-blocker-windows/releases/latest)
[![Total Downloads](https://img.shields.io/github/downloads/xachapyri-dev/skaM-max-blocker-windows/total)](https://github.com/xachapyri-dev/skaM-max-blocker-windows/releases)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Language: C#](https://img.shields.io/badge/Language-C%23-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform: .NET Framework 4.7.2+](https://img.shields.io/badge/.NET%20Framework-4.7.2%2B-512BD4.svg)](https://dotnet.microsoft.com/download/dotnet-framework)

Программа для блокировки нежелательного запуска мессенджера MAX (Макс) на операционной системе Windows.

## Скриншоты

<p>
  <img src="https://github.com/user-attachments/assets/76f6fc8e-a698-4d0f-8ecb-4b9c86625e58" alt="Снимок экрана 2025-08-24 130939" width="48%" />
  <img src="https://github.com/user-attachments/assets/a5bd9ed6-edeb-4e85-abca-cebc238369c6" alt="Снимок экрана 2025-08-24 131020" width="48%" />
</p>

### [📥 Скачать последнюю версию (Latest Release)](https://github.com/xachapyri-dev/skaM-max-blocker-windows/releases/latest)

---

## 💡 Идея проекта

Проект вдохновлен опасениями сообщества по поводу конфиденциальности и сбора данных мессенджером MAX, а также принудительным переходом на него в некоторых организациях. Цель — предоставить пользователям Windows инструмент для контроля над запуском этого приложения.

## 🤝 Вдохновление другими проектами

* **[Android приложение от scaik (scam-max-disabler)](https://github.com/scaik/scam-max-disabler)**
* **[Windows приложение от Марка Аддерли (Makuyan)](https://adderly.top/makuyan)**

## 🚀 Планы разработки (Devlog)

### 1. Многоуровневая защита
Планируется внедрение нескольких уровней защиты от мессенджера MAX:

* **Уровень 1 (Текущий)**: Добавление записи `Debugger` в реестр для `max.exe`.
    * *Путь реестра*: `HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options`
* **Уровень 2**: Отслеживание и блокировка скачивания установочного файла `MAX.msi`.
* **Уровень 3**: Блокировка доступа к сайтам, связанным с мессенджером.
* **Уровень 4**: Вместо повреждения файлов (что может быть небезопасно для системы), приложение будет удалять основную папку установленного приложения MAX.

### 2. Встроенные туториалы
Добавление раздела с пошаговыми инструкциями внутри приложения:
* Туториалы по ручной деактивации блокировщика.
* Инструкции по добавлению других приложений в список блокировки.

### 3. Режим блокировки сервисов Яндекса
Вдохновившись `MakuYan`, планируется добавление опции блокировки сервисов и IP-адресов Яндекса. Будет реализована возможность выборочной блокировки IP-адресов.

---

## ⚙️ Технические требования

* **Права администратора**: Требуется для внесения изменений в раздел реестра `HKEY_LOCAL_MACHINE`.
* **Платформа**: Установленный **.NET Framework v4.7.2** или выше.

---

## ⚠️ Предупреждение и отказ от ответственности

**ВНИМАНИЕ!**

Автор этой программы **не выступает против** мессенджера MAX и не призывает пользователей нарушать работу мессенджера или других программ.

* Все изменения реестра, внесённые вручную или программой, могут потенциально привести к сбоям в работе системы или её отказу.
* Скачивая и используя эту программу, **вы берёте на себя все риски**.
* Автор не несёт ответственности за возможный ущерб вашей системе, потерю данных или файлов.
* Приложение предоставляется **исключительно в ознакомительных или образовательных целях**.
* Вы несёте полную ответственность за использование приложения на своём устройстве и за соблюдение действующих правил и законов.

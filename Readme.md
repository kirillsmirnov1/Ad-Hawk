# Подключение модуля 

Добавь следующие строчки в `manifest.json`
```
"com.unity.ads": "3.6.1",
"trulden.ad-hawk": "https://github.com/kirillsmirnov1/Ad-Hawk.git",
```

# Инициализация Unity.Monetization 

1. Залогиниться в Юнити Хабе
2. В едиторе Manage Services → Ads → On
3. Выбрать существующую организацию
4. Create Project Id
5. COPPA (таргетим ли под детей) → No → Save
6. Нажать Ads→On еще раз и подождать
7. Снизу появятся GameId для магазинов, они понадобятся позже

# Использование модуля

1. Помести компонент `InitAds` туда, где у тебя происходит инициализация игры.
2. Проверь что ключи подтянулись и соответствуют ключам из Services→Ads→GameId

Чтобы показать рекламу, добавь `InterstitialAds` на сцену и вызови `ShowInterstitialAd()`
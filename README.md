# Calc
Поддерживает ввод цифр 1-0 с цифровой клавиатуры, ввод операций "/ * - +", Enter, Delete, ввод "," как десятичного разделителя.
Изменение операции после её выбора, если второй параметр не был введён.
Деление на ноль.
Отсутствующий первый и/или второй параметр.
Delete полностью очищает текущую операцию со всеми переменными.
Продолжение операций через "=". Для операций берётся конечное значение предыдущей операции.


Баги, исправления которых в процессе:
	При сбросе фокуса на любую из клавиш, Enter вызывает не функцию "=", а выбранную клавишу.
		(В поисках решения)

	При повторном вводе операции (через кнопки или клавиатурой), первый параметр становится равным второму, второй сбрасывается,
	запускается ожидание ввода.
		(ошибка при сбросе функций. Решение известно)


Возможное к добавлению:
	Ввод цифр с основной клавиатуры.
		(Пока не нашёл решения делать это короче, нежели в коде, не вижу смысла)

	Продолжение операции. Последующие вводы знаков "+ - * /" могут вызывать свои методы, сохранять значение и ожидать следующий параметр,
	Закрывается кнопкой "=".
		(Не сложно, только повторение уже использованного в коде. Не имеет смысла, так как не даст нового).
		(Исправлено частично. Операции продолжаются через "=")

	Назначение Backspace, как удаление последнего введённого символа.
		(Возможно, но ничего сложного. Увеличение количества строк, но новое в коде. Приоритет.)


Исправлено:
	21.04
	Если оба параметра равны null (Ввод "* - +") и нажатии "="/Enter - в окне вывода появляется "00",
	При использовании операции "/" этого бага не наблюдается, так как идёт проверка деления на ноль.
		(не везде предусмотрел этот вариант. Решение известно)

	При нажатии "=" и последующем вводе любой операции "/ * - +" первый параметр всегда будет равен "0"
		(Решение известно)

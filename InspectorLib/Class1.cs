using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    // Класс для работы с данными автоинспекции.
    public class FunctionInsp
    {
        // Название автоинспекции
        private string _inspectionName = "Автоинспекция г. Чита";

        // ФИО главного инспектора
        private string _chiefInspector = "Васильев Василий Иванович";

        // Список сотрудников автоинспекции
        private List<string> _workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        
        // Возвращает ФИО главного инспектора.
        public string GetInspector()
        {
            return _chiefInspector;
        }


        // Возвращает название автоинспекции.
        public string GetCarInspection()
        {
            return _inspectionName;
        }

        // Изменяет ФИО главного инспектора, если указанное ФИО есть в списке сотрудников.
        // <string ="fullname">Новое ФИО главного инспектора.
        // True, если инспектор успешно изменён; иначе False.
        public bool SetInspector(string fullname)
        {
            if (_workers.Contains(fullname))
            {
                _chiefInspector = fullname;
                return true;
            }
            return false;
        }

        // Генерирует государственный номер автомобиля.
        // <int ="number">Случайный номер.
        // <char ="symbol">Буква в верхнем регистре.
        // <int ="code">Код региона (по умолчанию 75).
        // <return> Сформированный госномер в формате SYMBOLnumber_CODE.
        public string GenerateNumber(int number, char symbol, int code = 75)
        {
            return $"{char.ToUpper(symbol)}{number:D4}_{code}";
        }

        // Возвращает список всех сотрудников автоинспекции.
        public List<string> GetWorker()
        {
            return new List<string>(_workers);
        }


        // Добавляет нового сотрудника в список сотрудников, если его там ещё нет.
        // <string ="fullname">ФИО нового сотрудника.
        public void AddWorker(string fullname)
        {
            if (!_workers.Contains(fullname))
            {
                _workers.Add(fullname);
            }
        }
    }
}


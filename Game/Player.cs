﻿namespace Game
{
    public class Player
    {
        private readonly string _name;
        public string Name { get { return _name; } }

        protected FieldCoords _lastAttackCoords;
        public FieldCoords LastAttackCoords { get { return _lastAttackCoords; } }

        private readonly Field _defenseField;
        public Field DefenseField { get { return _defenseField; } }

        private readonly Field _attackField;
        public Field AttackField { get { return _attackField; } }

        private readonly FileInfo _filePath;
        public FileInfo FilePath { get { return _filePath; } }

        public Player(string name, string filePath, Field defenseField, Field attackField)
        {
            _name = name;

            _attackField = attackField;

            _filePath = new FileInfo(filePath);

            _defenseField = defenseField;
            _defenseField.ParseFieldFromFile(_filePath);
        }

        public virtual Command Turn()
        {
            var command = CommandReader.ReadCommand(out string rawOutput);

            if (command.Type is CommandsEnum.SimpleAttack)
            {
                var attackCoords = new FieldCoords(rawOutput[0], int.Parse(rawOutput[1..]));

                if (_attackField[attackCoords] is FieldMarks.Empty
                 || _attackField[attackCoords] is FieldMarks.Ship)
                    _lastAttackCoords = attackCoords;
                else
                    command = new Command(CommandsEnum.Invalid);
            }

            return command;
        }
    }
}

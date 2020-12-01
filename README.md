# landing-spaceship

<div dir='rtl' lang='he'>
קישור למשחק: https://yarinsh.itch.io/landing-spaceship
דבר ראשון שעשיתי בניתי 

[KeyboardForceAdder]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/KeyboardForceAdder.cs)  
  
שאחראי על הזזת הדמות במשחק. הסקריפט בנוי בדומה ל [KeyboardMover]( https://github.com/gamedev-yarin/cross-the-road/blob/main/Assets/Scripts/move/KeyboardMover.cs)רק שהפעם בגלל שנעשה שימוש במנוע הפיזיקלי נעשה שימוש ב AddForce

לאחר מכן הוספתי [CollisionExploder]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/CollisionExploder.cs) שמטרתו לבדוק את חוזק ההתנגשות של החללית ולפוצץ אותה במידה וההתנגשות חזקה מידי. הסקריפט נלקח [מפהhttps://github.com/gamedev-at-ariel/04-physics-engine/blob/master/Assets/Scripts/2-dynamics/CollisionExploder.cs) והוא שונה בהתאם לצרכי משחק 3D.
בבניית השלב הראשון עלתה הבעיה שהשחקן יכול להתנגש בנקודת הסיום והמשחק יזהה את זה כהצלחה למרות שהשחקן היה אמור לחזור לתחילת השלב. לכן נוסף הסקריפט [VictoryDetector]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/VictoryDetector.cs)
הסקריפט מזהה התנגשות באובייקט וסופר מספר שניות (לפי החלטת מעצב השלב) ורק אם הדמות נשארה באובייקט לכל האורך שהוגד השחקן יעבור לשלב הבא. בנוסף הסקריפט בנוי כך שאפשר להוסיף שדה text ויוצג לשחקן ספירה לאחור על מנת שידע מתי הוא עובר לשלב הבא.
הסקריפטים [DestroyOnTrigger]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/DestroyOnTrigger.cs), [Mover]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/Mover.cs), [TimedSpawnerRandom]( https://github.com/gamedev-yarin/landing-spaceship/blob/main/Assets/Scripts/TimedSpawnerRandom.cs)  נלקחו ממטלות קודמות בשלמותם או בשינויים קטנים להתאמה של משחק 3D

</div>

# Match3-Unity-Game

Suggestions to organize the project:
1. Inside project there are some class which is access regularly by other class (Ex: GameManager, UIMainManager).
   - These class could be made into Singleton so that other class could access them directly instead of passing their references around, which will make the tracking process difficult when project grow bigger
   - Beside Singleton, an event system could also be considered to a way for classes communicating with each others.
     
2. For buttons inside this project, their clicked events are being assigned via script from gameobject other than their own. I think this method will also make tracking problems become more difficult
   - We could considered assign the method directly on the editor, or the script which handle the clicked event should be put inside the button gameobject for easier tracking

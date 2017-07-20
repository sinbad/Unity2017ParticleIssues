# Unity2017.1 Weird Particle Bug Repro

[Watch explanatory video](https://www.youtube.com/watch?v=QjMG4lvDQt0)

I've had a really weird issue with particle systems that are set to *not* play on awake in Unity 2017.1. 

If I move them and call Play(), even directly after instantiation, some particles get emitted in a different 
location, as if the velocity of moving them first has carried across to the emitter. No setting changes I've found
seem to fix it, and I'd love to know what I'm doing wrong or if this is a bug.



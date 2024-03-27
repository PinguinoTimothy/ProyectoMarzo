import ManejadorNivel from "../escenas/manejadornivel";

export default class Recolectables extends Phaser.Physics.Arcade.Group {
    private escena: ManejadorNivel ;
    
    constructor(escena: ManejadorNivel, nombreObjeto: string, idObjeto: string, animObjeto: string) {
        super(escena.physics.world, escena);        

        this.escena = escena;        
                
        this.addMultiple(this.escena.mapaNivel.createFromObjects(nombreObjeto, {name: idObjeto, key:idObjeto}));
        
        this.escena.physics.world.enable(this.children.entries);
        
        this.escena.anims.create({
            key: animObjeto,
            frames: idObjeto,
            frameRate: 20,
            repeat: -1
        });

        this.children.entries.map((recolectable: any) => {            
            recolectable.body.setAllowGravity(false);
            recolectable.body.setImmovable(true); 
            recolectable.play(animObjeto);            
        });
        
        this.escena.numObjetosRecolectar += this.children.entries.length;
    }

}

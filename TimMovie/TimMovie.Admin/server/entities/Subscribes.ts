import { Column, Entity, Index, ManyToMany, OneToMany } from "typeorm";
import { Films } from "./Films";
import { UserSubscribes } from "./UserSubscribes";

@Index("PK_Subscribes", ["id"], { unique: true })
@Entity("Subscribes", { schema: "public" })
export class Subscribes {
  @Column("uuid", { primary: true, name: "Id" })
  id: string;

  @Column("character varying", { name: "Name", length: 70 })
  name: string;

  @Column("real", { name: "Price", precision: 24 })
  price: number;

  @Column("text", { name: "Description", nullable: true })
  description: string | null;

  @ManyToMany(() => Films, (films) => films.subscribes)
  films: Films[];

  @OneToMany(() => UserSubscribes, (userSubscribes) => userSubscribes.subscribe)
  userSubscribes: UserSubscribes[];
}

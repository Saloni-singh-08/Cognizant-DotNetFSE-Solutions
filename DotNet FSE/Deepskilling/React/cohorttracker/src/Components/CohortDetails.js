import React from "react";
import styles from "../Styles/CohortDetails.module.css";

const cohorts = [
  {
    id: 1,
    name: "INTADMDF10 - .NET FSD",
    startedOn: "22-Feb-2022",
    currentStatus: "Scheduled",
    coach: "Ashwini",
    trainer: "Jojo Jose",
  },
  {
    id: 2,
    name: "ADM21JF014 - Java FSD",
    startedOn: "10-Sep-2021",
    currentStatus: "Ongoing",
    coach: "Apoorv",
    trainer: "Bisa Smith",
  },
  {
    id: 3,
    name: "CDBJF21025 - Java FSD",
    startedOn: "24-Dec-2021",
    currentStatus: "Ongoing",
    coach: "Ashwini",
    trainer: "John Doe",
  },
];

function CohortDetails() {
  return (
    <div>
      <h1>Cohorts Details</h1>

      {cohorts.map((cohort) => (
        <div key={cohort.id} className={styles.box}>
          <h3
            style={{
              color:
                cohort.currentStatus === "Ongoing"
                  ? "green"
                  : "blue",
            }}
          >
            {cohort.name}
          </h3>

          <dl>
            <dt>Started On</dt>
            <dd>{cohort.startedOn}</dd>

            <dt>Current Status</dt>
            <dd>{cohort.currentStatus}</dd>

            <dt>Coach</dt>
            <dd>{cohort.coach}</dd>

            <dt>Trainer</dt>
            <dd>{cohort.trainer}</dd>
          </dl>
        </div>
      ))}
    </div>
  );
}

export default CohortDetails;